using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体加载时，为窗体设置皮肤
            skinEngine1.SkinFile = @"SkinEngine\skin\MacOS.ssk";
            //为pictureBox加载默认图片
            pictureBox1.Image = Image.FromFile(@"Images\1.jpg");
            //设置图片在pictureBox中的布局
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //取消自动播放
            musicPalyer.settings.autoStart = false;
            //设置默认播放歌曲
            //musicPalyer.URL = @"G:\音乐\Music\勇气 - 梁静茹.mp3";

        }
        int i_skin = 0;
        private void btnChange_Click(object sender, EventArgs e)
        {
            //把所有皮肤文件全部读取进来
            //获取皮肤文件夹所有皮肤文件的全路径，存储到stylePath数组中
            string[] stylePath = Directory.GetFiles(Application.StartupPath +@"\SkinEngine\skin");
            //点击更换皮肤实际上就是从stylePath数组中拿到一个皮肤的全路径赋值给skinFile

            i_skin++;//让皮肤发生改变
            if (i_skin == stylePath.Length)
            {
                i_skin = 0;
            }
            skinEngine1.SkinFile = stylePath[i_skin];

        }
        int i_imgs = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //每隔指定秒数更换图片
            //读取所有图片文件
            string[] imgsPath = Directory.GetFiles(@"Images");

            i_imgs++;
            if (i_imgs == imgsPath.Length)
            {
                i_imgs = 0;
            }
            pictureBox1.Image = Image.FromFile(imgsPath[i_imgs]);
        }

        //实现播放器播放和暂停
        private void btnPlayOrPause_Click(object sender, EventArgs e)
        {
            if (btnPlayOrPause.Text == "播放")
            {
                //我们想做的事情是播放音乐
                musicPalyer.Ctlcontrols.play();
            }
            else if (btnPlayOrPause.Text == "暂停")
            {
                //想要做的事情是暂停
                musicPalyer.Ctlcontrols.pause();
            }

        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            //点击停止
            musicPalyer.Ctlcontrols.stop();
        }

        //选择音乐
        //存储音乐文件全路径
        List<string> listSongs = new List<string>();
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //show之前设置对话框属性
            //设置打开对话框的标题
            ofd.Title = "请选择要播放的音乐文件";
            //设置对话框可以多选
            ofd.Multiselect = true;
            //设置打开文件类型
            ofd.Filter = "音乐文件|*.mp3|所有文件|*.*";
            //设置打开文件的初始路径,此处用的是相对路径
            ofd.InitialDirectory = Application.StartupPath+ @"\Music";
            //展示对话框
            ofd.ShowDialog();

            //获得对话框中选中文件的全路径
            string[] filePath = ofd.FileNames;
            //根据全路径截取文件名加载到ListBox列表中
            for (int i = 0; i < filePath.Length; i++)
            {
                //将全路径存储到集合中
                listSongs.Add(filePath[i]);
                //将文件名截取出来放到listBox中
                listBox1.Items.Add(Path.GetFileName(filePath[i]));
            }
            //如果播放列表为空则添加歌曲时，选中项的索引为第一首歌曲
            //if (listBox1.SelectedIndex == -1)
            //{
            //    listBox1.SelectedIndex = 0;
            //    musicPalyer.URL = listSongs[listBox1.SelectedIndex];
            //}

        }

        //双击播放
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //当列表为空时，双击选择歌曲的下标索引为-1
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            //当我们双击某一首音乐文件时，我们需要找到双击的文件名所对应的全路径
            musicPalyer.URL = listSongs[listBox1.SelectedIndex];
            musicPalyer.Ctlcontrols.play();
            
        }

        //上一曲
        private void btnUpMusic_Click(object sender, EventArgs e)
        {
            //获得当前选中项的索引
            int index = listBox1.SelectedIndex;
            //将之前选中项的索引全部清空，确保以后只有一个文件被选中
            listBox1.SelectedIndices.Clear();
            //当列表为空时，下标索引为-1
            if (index == -1)
            {
                return;
            }
            index--;
            //如果选中的是列表中第一首歌曲，则上一首为最后一首歌曲
            if (index < 0)
            {
                index = listBox1.Items.Count - 1;
            }
            //将改变后的选中项的索引赋值给当前选中项的索引
            listBox1.SelectedIndex = index;
            //通过索引从泛型集合中拿到全路径赋值给播放器的URL
            musicPalyer.URL = listSongs[index];
            musicPalyer.Ctlcontrols.play();
            //btnPlayOrPause.Text = "暂停";

        }

        private void btnDownMusic_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.SelectedIndices.Clear();
            if (index == -1)
            {
                return;
            }
            index++;
            //在最后一首点击了下一首
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index;
            musicPalyer.URL = listSongs[index];
            musicPalyer.Ctlcontrols.play();
        }

        //多选删除
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //首先要获得选中项的个数
            int count = listBox1.SelectedItems.Count;
            //逐条删除
            for (int i = 0; i < count; i++)
            {
                //先删集合
                listSongs.RemoveAt(listBox1.SelectedIndex);
                //再删除列表
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        //根据时间差进行下一曲
        private void timer2_Tick(object sender, EventArgs e)
        {
        //    //确保当前正在有音乐播放时显示信息，否则会报错
            if (musicPalyer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //显示歌曲时间信息
                lblInfo.Text = musicPalyer.Ctlcontrols.currentPosition + "\r\n" + musicPalyer.Ctlcontrols.currentPositionString + "\r\n" + musicPalyer.currentMedia.duration + "\r\n" + musicPalyer.currentMedia.durationString;
            }
        //    //利用时间差来实现下一曲，如果当前播放的总时间—播放的时间<1s则进行下一曲
        //    if (musicPalyer.currentMedia.duration - musicPalyer.Ctlcontrols.currentPosition < 1 && musicPalyer.currentMedia.duration - musicPalyer.Ctlcontrols.currentPosition>0)
        //    {
        //        int index = listBox1.SelectedIndex;
        //        listBox1.SelectedIndices.Clear();
        //        if (index == -1)
        //        {
        //            return;
        //        }
        //        index++;
        //        //在最后一首点击了下一首
        //        if (index == listBox1.Items.Count)
        //        {
        //            index = 0;
        //        }
        //        listBox1.SelectedIndex = index;
        //        musicPalyer.URL = listSongs[index];
        //        musicPalyer.Ctlcontrols.play();
        //        btnPlayOrPause.Text = "暂停";
        //    }
        }

         //根据播放器状态进行下一曲

        //加载歌词
        void LoadLrc()
        {
            
            //首先获得当前播放的歌曲
            string lrcPath = listSongs[listBox1.SelectedIndex]+".lrc";
            //判断当前播放歌曲是否存在歌词文件
            if (File.Exists(lrcPath))
            {
                //如果歌词存在
                //逐行读取文件
                timer3.Enabled = true;
                string[] lrcText = File.ReadAllLines(lrcPath, Encoding.Default);
                //截取歌词和时间
                FormatLrc(lrcText);
            }
            else
            {
                //如果不存在
                timer3.Enabled = false;
                lblLrc.Text = "-------歌词未找到-------";
            }
        }

        //存储歌词时间
        List<double> listTime = new List<double>();
        //存储歌曲
        List<string> listLrc = new List<string>();

        //截取歌词和时间
        void FormatLrc(string[] lrcText)
        {
            //[00:00.10]大城小爱 - 王力宏
            //lrcTemp[0]  00:00.10
            //lrcTemp[1]  大城小爱 - 王力宏
            for (int i = 0; i < lrcText.Length; i++)
            {
               string[] lrcTemp =  lrcText[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);//去掉中括号
                //将歌词存储到集合中
                listLrc.Add(lrcTemp[1]);
                //lrcNewTemp[0]  00
                //lrcNewTemp[1]  00.10
                string[] lrcNewTemp = lrcTemp[0].Split(new char[]{':'},StringSplitOptions.RemoveEmptyEntries);
                //得到double类型的时间
                double time = double.Parse(lrcNewTemp[0]) * 60 + double.Parse(lrcNewTemp[1]);
                //将时间放入到listTime中
                listTime.Add(time);



            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            double currentTime = musicPalyer.Ctlcontrols.currentPosition;
            for (int i = 0; i < listTime.Count - 1; i++)
            {
                if(currentTime>=listTime[i]&&currentTime<listTime[i+1])
                {
                    lblLrc.Text=listLrc[i];
                }
                else if (currentTime >= listTime[i + 1])
                {
                    lblLrc.Text = listLrc[i + 1];
                }
            }
        }

        private void musicPalyer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //当播放器的状态发生改变时，判断当前音乐播放器的状态是否达到了ended，如果是ended则进行下一曲
            if (musicPalyer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                //进行下一曲
                int index = listBox1.SelectedIndex;
                listBox1.SelectedIndices.Clear();
                if (index == -1)
                {
                    return;
                }
                index++;
                //已经是最后一首
                if (index == listBox1.Items.Count)
                {
                    index = 0;
                }
                listBox1.SelectedIndex = index;
                musicPalyer.URL = listSongs[index];

            }
            if (musicPalyer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //加载歌词
                LoadLrc();
                btnPlayOrPause.Text = "暂停";
            }
            if (musicPalyer.playState == WMPLib.WMPPlayState.wmppsPaused || musicPalyer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                btnPlayOrPause.Text = "播放";
            }
            if (musicPalyer.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                //捕获异常
                try
                {
                    musicPalyer.Ctlcontrols.play();
                    btnPlayOrPause.Text = "暂停";
                }
                catch
                { }
            }
        }
    }
}
