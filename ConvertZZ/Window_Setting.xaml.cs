﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ConvertZZ
{
    /// <summary>
    /// Window_Setting.xaml 的互動邏輯
    /// </summary>
    public partial class Window_Setting : Window, INotifyPropertyChanged
    {
        public Window_Setting()
        {
            LoadSetting();
            DataContext = this;
            InitializeComponent();         
        }
        private void LoadSetting()
        {
            _AssistiveTouchEnable = App.Settings.AssistiveTouch;
            _VocabularyCorrenctionEnable = App.Settings.VocabularyCorrection;
            _PromptEnable = App.Settings.Prompt;
            _RecognitionEncodingEnable = App.Settings.RecognitionEncoding;
            _MaxPriviewLength = App.Settings.MaxLengthPreview.ToString();

            _DefaultPath = App.Settings.FileConvert.DefaultPath;
            _FixLabel = App.Settings.FileConvert.FixLabel;
            _TypeFilter = App.Settings.FileConvert.TypeFilter;
            _UnicodeAddBom = App.Settings.FileConvert.UnicodeAddBom;

            _Quick_L1 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.LeftClick_Ctrl);
            _Quick_L2 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.LeftClick_Alt);
            _Quick_L3 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.LeftClick_Shift);
            _Quick_L4 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.LeftDrop_Ctrl);
            _Quick_L5 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.LeftDrop_Alt);
            _Quick_L6 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.LeftDrop_Shift);
            _Quick_R1 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.RightClick_Ctrl);
            _Quick_R2 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.RightClick_Alt);
            _Quick_R3 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.RightClick_Shift);
            _Quick_R4 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.RightDrop_Ctrl);
            _Quick_R5 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.RightDrop_Alt);
            _Quick_R6 = Action.SingleOrDefault(x => x.Value == App.Settings.QuickStart.RightDrop_Shift);

            _AutoCopy = App.Settings.HotKey.AutoCopy;
            _AutoPaste = App.Settings.HotKey.AutoPaste;
            _ShortCut1_IsActived = App.Settings.HotKey.Feature1.Enable;
            _ShortCut1_Action = Action.SingleOrDefault(x => x.Value == App.Settings.HotKey.Feature1.Action);
            _ShortCut1_Key = App.Settings.HotKey.Feature1.Key;
            _ShortCut1_ModifyKey = App.Settings.HotKey.Feature1.Modift;
            _ShortCut2_IsActived = App.Settings.HotKey.Feature2.Enable;
            _ShortCut2_Action = Action.SingleOrDefault(x => x.Value == App.Settings.HotKey.Feature2.Action);
            _ShortCut2_Key = App.Settings.HotKey.Feature2.Key;
            _ShortCut2_ModifyKey = App.Settings.HotKey.Feature2.Modift;
            _ShortCut3_IsActived = App.Settings.HotKey.Feature3.Enable;
            _ShortCut3_Action = Action.SingleOrDefault(x => x.Value == App.Settings.HotKey.Feature3.Action);
            _ShortCut3_Key = App.Settings.HotKey.Feature3.Key;
            _ShortCut3_ModifyKey = App.Settings.HotKey.Feature3.Modift;
            _ShortCut4_IsActived = App.Settings.HotKey.Feature4.Enable;
            _ShortCut4_Action = Action.SingleOrDefault(x => x.Value == App.Settings.HotKey.Feature4.Action);
            _ShortCut4_Key = App.Settings.HotKey.Feature4.Key;
            _ShortCut4_ModifyKey = App.Settings.HotKey.Feature4.Modift;
        }
        private void SaveSetting()
        {
            App.Settings.AssistiveTouch = AssistiveTouchEnable;
            App.Settings.VocabularyCorrection = VocabularyCorrenctionEnable;
            App.Settings.Prompt = PromptEnable;
            App.Settings.RecognitionEncoding = RecognitionEncodingEnable;
            App.Settings.MaxLengthPreview = int.Parse(MaxPriviewLength);

            App.Settings.FileConvert.DefaultPath = DefaultPath;
            App.Settings.FileConvert.FixLabel = FixLabel;
            App.Settings.FileConvert.TypeFilter = TypeFilter;
            App.Settings.FileConvert.UnicodeAddBom = UnicodeAddBom;

            App.Settings.QuickStart.LeftClick_Ctrl = Quick_L1.Value;
            App.Settings.QuickStart.LeftClick_Alt = Quick_L2.Value;
            App.Settings.QuickStart.LeftClick_Shift = Quick_L3.Value;
            App.Settings.QuickStart.LeftDrop_Ctrl = Quick_L4.Value;
            App.Settings.QuickStart.LeftDrop_Alt = Quick_L5.Value;
            App.Settings.QuickStart.LeftDrop_Shift = Quick_L6.Value;
            App.Settings.QuickStart.RightClick_Ctrl = Quick_R1.Value;
            App.Settings.QuickStart.RightClick_Alt = Quick_R2.Value;
            App.Settings.QuickStart.RightClick_Shift = Quick_R3.Value;
            App.Settings.QuickStart.RightDrop_Ctrl = Quick_R4.Value;
            App.Settings.QuickStart.RightDrop_Alt = Quick_R5.Value;
            App.Settings.QuickStart.RightDrop_Shift = Quick_R6.Value;

            App.Settings.HotKey.AutoCopy = AutoCopy;
            App.Settings.HotKey.AutoPaste = AutoPaste;
            App.Settings.HotKey.Feature1.Enable = ShortCut1_IsActived;
            App.Settings.HotKey.Feature1.Action =ShortCut1_Action.Value;
            App.Settings.HotKey.Feature1.Key = ShortCut1_Key;
            App.Settings.HotKey.Feature1.Modift = ShortCut1_ModifyKey;
            App.Settings.HotKey.Feature2.Enable = ShortCut2_IsActived;
            App.Settings.HotKey.Feature2.Action = ShortCut2_Action.Value;
            App.Settings.HotKey.Feature2.Key = ShortCut2_Key;
            App.Settings.HotKey.Feature2.Modift = ShortCut2_ModifyKey;
            App.Settings.HotKey.Feature3.Enable = ShortCut3_IsActived;
            App.Settings.HotKey.Feature3.Action = ShortCut3_Action.Value;
            App.Settings.HotKey.Feature3.Key = ShortCut3_Key;
            App.Settings.HotKey.Feature3.Modift = ShortCut3_ModifyKey;
            App.Settings.HotKey.Feature4.Enable = ShortCut4_IsActived;
            App.Settings.HotKey.Feature4.Action = ShortCut4_Action.Value;
            App.Settings.HotKey.Feature4.Key = ShortCut4_Key;
            App.Settings.HotKey.Feature4.Modift = ShortCut4_ModifyKey;


            App.Save();
        }
        public static Dictionary<string, string> Action { get; } = new Dictionary<string, string>()
        {
            { "無" , "0" } , 
            { "隱藏/顯示懸浮球" , "1" } , 
            { "GBK>Big5" , "a1" } , 
            { "Big5>GBK" , "a2" } , 
            { "Unicod簡>Unicode繁" , "a3" } , 
            { "Unicode繁>Unicode簡" , "a4" } , 
            { "Unicode>Html Code十進制" , "za1" } , 
            { "Unicode>Html Code十六進制" , "za2" } , 
            { "HTML Code>Unicode" , "za3" } , 
            { "Unicode>GBK" , "zb1" } , 
            { "Unicode>Big5" , "zb2" } , 
            { "Unicode>Shift-JIS" , "zb3" } , 
            { "Shift-JIS>GBK" , "zc1" } , 
            { "Shift-JIS>Big5" , "zc2" } , 
            { "GBK>Shift-JIS" , "zc3" } , 
            { "Big5>Shift-JIS" , "zc4" } , 
            { "HZ>GBK" , "zd1" } , 
            { "HZ>Big5" , "zd1" } , 
            { "GBK>HZ" , "zd1" } , 
            { "Big5>HZ" , "zd1" }
        };
        private bool _AssistiveTouchEnable, _VocabularyCorrenctionEnable, _PromptEnable, _RecognitionEncodingEnable;
        private string _MaxPriviewLength;
        private KeyValuePair<string, string> _Quick_L1, _Quick_L2, _Quick_L3, _Quick_L4, _Quick_L5, _Quick_L6;
        private KeyValuePair<string, string> _Quick_R1, _Quick_R2, _Quick_R3, _Quick_R4, _Quick_R5, _Quick_R6;
        private bool _UnicodeAddBom;
        private string _DefaultPath, _TypeFilter, _FixLabel;
        private bool _AutoCopy, _AutoPaste;
        private bool _ShortCut1_IsActived, _ShortCut2_IsActived, _ShortCut3_IsActived, _ShortCut4_IsActived;
        private KeyValuePair<string, string> _ShortCut1_Action, _ShortCut2_Action, _ShortCut3_Action, _ShortCut4_Action;
        private string _ShortCut1_Key, _ShortCut1_ModifyKey, _ShortCut2_Key, _ShortCut2_ModifyKey, _ShortCut3_Key, _ShortCut3_ModifyKey, _ShortCut4_Key, _ShortCut4_ModifyKey;


        public bool AssistiveTouchEnable { get => _AssistiveTouchEnable; set { _AssistiveTouchEnable = value; Owner.Visibility = value ? Visibility.Visible : Visibility.Hidden; OnPropertyChanged(); SaveSetting(); } }
        public bool VocabularyCorrenctionEnable { get => _VocabularyCorrenctionEnable; set { _VocabularyCorrenctionEnable = value; OnPropertyChanged(); SaveSetting(); } }
        public bool PromptEnable { get => _PromptEnable; set { _PromptEnable = value; OnPropertyChanged(); SaveSetting(); } }
        public bool RecognitionEncodingEnable { get => _RecognitionEncodingEnable; set { _RecognitionEncodingEnable = value; OnPropertyChanged(); SaveSetting(); } }

        public string MaxPriviewLength { get => _MaxPriviewLength; set { _MaxPriviewLength = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> Quick_L1 { get => _Quick_L1; set { _Quick_L1 = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> Quick_L2 { get => _Quick_L2; set { _Quick_L2 = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> Quick_L3 { get => _Quick_L3; set { _Quick_L3 = value; OnPropertyChanged(); SaveSetting(); } }

        private void TextBox_ShortCut_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            TextBox textbox = sender as TextBox;            
            textbox.Text = (e.Key == Key.System ? e.SystemKey : e.Key== Key.ImeProcessed?e.ImeProcessedKey:e.Key).ToString();
        }
        private void TextBox_ShortCut_Modify_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            TextBox textbox = sender as TextBox;
            textbox.Text = e.KeyboardDevice.Modifiers.ToString();            
        }
        public KeyValuePair<string, string> Quick_L4 { get => _Quick_L4; set { _Quick_L4 = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> Quick_L5 { get => _Quick_L5; set { _Quick_L5 = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> Quick_L6 { get => _Quick_L6; set { _Quick_L6 = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> Quick_R1 { get => _Quick_R1; set { _Quick_R1 = value; OnPropertyChanged(); SaveSetting(); } }        
        public KeyValuePair<string, string> Quick_R2 { get => _Quick_R2; set { _Quick_R2 = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> Quick_R3 { get => _Quick_R3; set { _Quick_R3 = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> Quick_R4 { get => _Quick_R4; set { _Quick_R4 = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> Quick_R5 { get => _Quick_R5; set { _Quick_R5 = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> Quick_R6 { get => _Quick_R6; set { _Quick_R6 = value; OnPropertyChanged(); SaveSetting(); } }
        public string DefaultPath { get => _DefaultPath; set { _DefaultPath = value; OnPropertyChanged(); SaveSetting(); } }
        public string TypeFilter { get => _TypeFilter; set { _TypeFilter = value; OnPropertyChanged(); SaveSetting(); } }
        public string FixLabel { get => _FixLabel; set { _FixLabel = value; OnPropertyChanged(); SaveSetting(); } }

        public bool AutoCopy { get => _AutoCopy; set { _AutoCopy = value; OnPropertyChanged(); SaveSetting(); } }
        public bool AutoPaste { get => _AutoPaste; set { _AutoPaste = value; OnPropertyChanged(); SaveSetting(); } }

        public string ShortCut1_Key { get => _ShortCut1_Key; set { _ShortCut1_Key = value; OnPropertyChanged(); SaveSetting(); } }
        public string ShortCut1_ModifyKey { get => _ShortCut1_ModifyKey; set { _ShortCut1_ModifyKey = value; OnPropertyChanged(); SaveSetting(); } }
        public string ShortCut2_Key { get => _ShortCut2_Key; set { _ShortCut2_Key = value; OnPropertyChanged(); SaveSetting(); } }
        public string ShortCut2_ModifyKey { get => _ShortCut2_ModifyKey; set { _ShortCut2_ModifyKey = value; OnPropertyChanged(); SaveSetting(); } }
        public string ShortCut3_Key { get => _ShortCut3_Key; set { _ShortCut3_Key = value; OnPropertyChanged(); SaveSetting(); } }
        public string ShortCut3_ModifyKey { get => _ShortCut3_ModifyKey; set { _ShortCut3_ModifyKey = value; OnPropertyChanged(); SaveSetting(); } }
        public string ShortCut4_Key { get => _ShortCut4_Key; set { _ShortCut4_Key = value; OnPropertyChanged(); SaveSetting(); } }
        public string ShortCut4_ModifyKey { get => _ShortCut4_ModifyKey; set { _ShortCut4_ModifyKey = value; OnPropertyChanged(); SaveSetting(); } }

        public bool ShortCut1_IsActived { get => _ShortCut1_IsActived; set { _ShortCut1_IsActived = value; OnPropertyChanged(); SaveSetting(); } }
        public bool ShortCut2_IsActived { get => _ShortCut2_IsActived; set { _ShortCut2_IsActived = value; OnPropertyChanged(); SaveSetting(); } }
        public bool ShortCut3_IsActived { get => _ShortCut3_IsActived; set { _ShortCut3_IsActived = value; OnPropertyChanged(); SaveSetting(); } }
        public bool ShortCut4_IsActived { get => _ShortCut4_IsActived; set { _ShortCut4_IsActived = value; OnPropertyChanged(); SaveSetting(); } }

        public KeyValuePair<string, string> ShortCut1_Action { get => _ShortCut1_Action; set { _ShortCut1_Action = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> ShortCut2_Action { get => _ShortCut2_Action; set {_ShortCut2_Action = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> ShortCut3_Action { get => _ShortCut3_Action; set { _ShortCut3_Action = value; OnPropertyChanged(); SaveSetting(); } }
        public KeyValuePair<string, string> ShortCut4_Action { get => _ShortCut4_Action; set{ _ShortCut4_Action = value; OnPropertyChanged(); SaveSetting(); } }

        public bool UnicodeAddBom { get => _UnicodeAddBom; set { _UnicodeAddBom = value; OnPropertyChanged(); SaveSetting(); } }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
