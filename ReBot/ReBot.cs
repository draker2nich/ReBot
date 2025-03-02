// Decompiled with JetBrains decompiler
// Type: ReBot.ReBot
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using JjwJ6VfnOHRdZElDpR;
using Lhhg1shfS0NAhSBvAD;
using rD9BTdvLIJYvvCMKZ8;
using ReBot.Classes;
using ReBot.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace ReBot
{
  public class ReBot : Form, nRqRRt9e8AGSw2CcaZ
  {
    private CultureInfo vhv87XeDDl;
    public static ExWebBrowser wb;
    private WebBrowserDocumentCompletedEventArgs qGq89kW1OQ;
    private Settings hrV8kI7I7o;
    public Icon ico;
    private string JGj8QuSuwo;
    private cIjYbKS9IK6bxWCBX7 GV18sHIjZv;
    private List<string> naK8JrTJJH;
    internal bool zR68ZHDrFh;
    private bool hU885e0ut4;
    private bool OQP88QNSPv;
    private bool UMZ8LwRmEM;
    private bool hiS81YhXtp;
    private bool c6882lfjAQ;
    private string nWk8TEL7OK;
    private string g8m8lIKEJ5;
    private string pJc8Njredb;
    private string kBW8VNQiZA;
    private string L8D8t4giIx;
    private string RnY8MoMwBo;
    private string Ass8HuyXMf;
    private string kVF8v6XHP1;
    private Dictionary<int, int> Sxt8cyRNWr;
    private HtmlDocument uZM8ja5T3b;
    private string gM58ypk65p;
    private string Lij8SC1qtU;
    private string LBN8OZfkFV;
    private int cWT8qeNQRD;
    private int FFM8XrqFu2;
    private int H2X8D6wDI4;
    private string F1x8YdVvR0;
    private string gls8FOTLB7;
    private string JSF8ed8M1X;
    private PostURLAction Q1O8d6vUh4;
    private Queue<QueueAction> AJX8mpYrvq;
    private DateTime rYw8PLEdUO;
    private FormWindowState aQI835bs80;
    private List<ReBot.ReBot.PlayerInfo> Ksn8xqkXDb;
    private List<ReBot.ReBot.sIAc91KU8cmcxURFKD> w5a8E3GWNq;
    private List<ReBot.ReBot.PlayerInfo> YtM80QL9rC;
    private string BKT8GSo7br;
    private string zZm8AI1lPA;
    public DateTime CurrentDateTime;
    private ReBot.ReBot.Yh2ZNv195dWJ5pHZZU[] KXt8Cr09cc;
    private ReBot.ReBot.n1KFWaAX0X9XjDepdR GK284gbIIO;
    private bool vT68nDJ5wj;
    private List<int> N298wDMOZA;
    private string Oad8uRh3K8;
    private int MIF8IZGL3F;
    public Hashtable RemoteSetting;
    public Hashtable RemoteOptions;
    private bool Udl8BjdgF5;
    private int OiX8bIwx7R;
    private bool wm38WLxUiO;
    private long AA58gTnXnO;
    private long wdB8pDkGK0;
    private long D178acIRte;
    private string xcU8hhIqlQ;
    private bool RYj8RVydkD;
    private Dictionary<string, int> WIK86LLuyB;
    private bool ygG8UOR3Xr;
    private int[] Xmq8oIOum3;
    public static string LocationURL;
    private ReBot.ReBot.A9qSyp7TWVrBx9ibTo cWQ8rNkS0o;
    private int Xia8KH3Mbk;
    private int zhe8ic1Vyn;
    private string Awy8zRvTEN;
    private static readonly Random GGOL78mRRd;
    private static readonly object g6NL9Fvx4A;
    private IContainer LolLk7SboE;
    private NotifyIcon M48LQOQufj;
    private Panel BM2LsG4PCC;
    private TabControl db6LJd20hw;
    private TabPage IqTLZonbZ5;
    private TabPage myZL5lfv0F;
    private TabControl nNQL8QI2hO;
    private TabPage cRLLLm4NCi;
    private GroupBox ovZL1hOfBh;
    private Label WZSL2FFXce;
    private ComboBox BKXLTC531K;
    private TabPage eG8LllX9Qg;
    private TabPage B0uLN1jxFI;
    private TextBox IjKLVJ3yDq;
    private Label mYfLtILnsV;
    private TextBox QbGLMgXx37;
    private Label RIdLHMgjwV;
    private GroupBox wX1LvU8ZuA;
    private Label NoCLc9ZSW3;
    private TextBox aDVLjtLKYY;
    private TextBox MAOLyfqy27;
    private CheckBox NBOLSEE0ik;
    private Label cIeLOQwL89;
    private Label QvELqLqmTH;
    private TextBox y3qLXGUVQw;
    private TextBox MMWLDBOM77;
    private TabPage QyNLYw9fOp;
    private Label i5NLFTpZIJ;
    private Panel zbGLebYG12;
    private Panel WZKLdKEcgY;
    private Button T3OLm7nlS0;
    private Button XnyLPMlRqy;
    private Button sMiL3KgVqr;
    private Button fOGLxsEEvN;
    private TextBox uGVLEowg7g;
    private Label CjNL087fQO;
    private TextBox AGELGHIwd1;
    private TextBox tuOLAQUvVZ;
    private Label mM5LCAandg;
    private TabPage X43L4NNkJu;
    private GroupBox c8WLnWg08q;
    private CheckBox uxbLw34qub;
    private TextBox sSDLuqSRv2;
    private CheckBox aiPLIeDfWC;
    private TextBox ehdLBwTBr3;
    private CheckBox FUSLbWKtH6;
    private TextBox b3PLWJMTLx;
    private CheckBox ASTLgaVI4d;
    private TextBox JMMLpvpV2H;
    private TextBox GRVLa3fJrJ;
    private CheckBox tnCLhKIUwb;
    private TextBox z6oLRHIdRi;
    private CheckBox e0fL6UGdB9;
    private TextBox f8bLUYs8i4;
    private CheckBox YFYLoxUrmq;
    private TextBox QK9LrJUmKg;
    private CheckBox BhmLf9aV3x;
    private TextBox IpoLK7iQQU;
    private CheckBox gyvLiZWY6p;
    private TextBox g9pLzwg10m;
    private CheckBox d5S17ih3Dv;
    private TextBox yvF19FXraO;
    private CheckBox tOA1khvMwP;
    private TextBox Rrj1Q4OxQR;
    private CheckBox ktH1sh3fGl;
    private TextBox PGx1Jhi0s8;
    private CheckBox uAB1ZRyhSK;
    private TextBox gwW15HPHnw;
    private CheckBox oeD181vXhO;
    private GroupBox Xqw1LVya0s;
    private TableLayoutPanel jWw11A82ZZ;
    private CheckBox dis127xbkS;
    private CheckBox Eks1TWvflM;
    private CheckBox op61l0MWeC;
    private CheckBox kJn1NJJUH5;
    private CheckBox Xjx1Vvtqu2;
    private CheckBox Rfq1tf4esK;
    private CheckBox oM61McnRD3;
    private Label ovN1HEWdlT;
    private Label cyF1v6jIPX;
    private Label MRa1cNGqtY;
    private Label lHL1jVELxx;
    private Label J6v1ykC1Bv;
    private Label ado1Sny6vh;
    private Label a6k1O3MWrs;
    private Label GtK1qHbg0T;
    private Label HNa1XSNP7q;
    private TextBox TBe1DSAYUt;
    private TextBox Li01YYbeR9;
    private TextBox bV31FskvdI;
    private Label War1ehD8rk;
    private TextBox NdM1d6DW74;
    private TextBox OeP1moITeQ;
    private Label iC21PVJ6d7;
    private TextBox fl213anMyM;
    private Label Xca1xJrBmL;
    private TextBox eKF1Es7KF0;
    private TextBox rDW10OC0KL;
    private TextBox XN11GqtKBH;
    private TextBox zdW1AoFonD;
    private TextBox adR1CBCjnL;
    private TextBox z9E142lk93;
    private TextBox RHd1n4Ge3s;
    private TextBox zyZ1w3Gmt6;
    private TextBox sMX1uLLTHw;
    private TextBox mBN1IbCqqU;
    private GroupBox onI1BbKe3q;
    private Label Fyh1bQEudL;
    private TextBox M1r1WAm4qZ;
    private Label ejO1gtBxD1;
    private TextBox Kw01poti2I;
    private Timer KEc1aKKALN;
    private Timer IyI1hjMnKP;
    private CheckBox OTj1RJOk9I;
    private Timer jas16N7enN;
    private TabPage HfK1UGDypR;
    private TableLayoutPanel MFX1o4IeMA;
    private Label tGm1rcgQc3;
    private Label Y3R1fq3oFJ;
    private Label Hl71K3ooYO;
    private Label bpZ1i8Wi3C;
    private Label NJw1zwNAuq;
    private Label G6J27qjPAo;
    private Label lkx294t4v2;
    private Label hq22kArqE5;
    private Label Iyp2Q28m9v;
    private Label tOh2st6xFw;
    private Label gZe2JGqZ12;
    private CheckBox DfO2ZPZKjU;
    private DateTimePicker CAc25cNQ6e;
    private DateTimePicker GEv28NU6ym;
    private CheckBox jia2LkopGm;
    private CheckBox YQv21QkDbV;
    private CheckBox PdW22TUdqI;
    private CheckBox rpx2TGfUYq;
    private CheckBox fio2loExgN;
    private CheckBox b1A2NVIkvQ;
    private CheckBox NyM2V9sB4A;
    private CheckBox VYa2t7P9f5;
    private CheckBox FIn2MU3inX;
    private CheckBox hwI2H4vgRv;
    private DateTimePicker dLf2vwlMVq;
    private DateTimePicker Er32cGu0fb;
    private CheckBox sTl2jo9LtW;
    private CheckBox gM32yk0R7Y;
    private CheckBox tIH2SaQu0e;
    private CheckBox G2K2OUxJX6;
    private CheckBox s5t2qfeFJT;
    private CheckBox bZd2XfLk3g;
    private CheckBox MSo2DVBLQO;
    private CheckBox KDN2YbhuO0;
    private CheckBox A622FpgeSM;
    private CheckBox zAy2epRaSx;
    private DateTimePicker SgK2dSPpCe;
    private DateTimePicker KSJ2m1N4PW;
    private CheckBox Di52PhieeE;
    private CheckBox DSa23vvW1C;
    private CheckBox Kfq2xqtkWg;
    private CheckBox QVU2Eq7J18;
    private CheckBox Yg920QWFaH;
    private CheckBox kyx2GWodir;
    private CheckBox zUv2Aqfgax;
    private CheckBox bHI2CTBxxR;
    private CheckBox q9T24yJNZa;
    private CheckBox SkL2n3YHe3;
    private DateTimePicker rXB2wenUD8;
    private DateTimePicker S4u2ujJSHr;
    private CheckBox rAC2I1sQOn;
    private CheckBox ivB2BGu5Fw;
    private CheckBox pia2b5lsK4;
    private CheckBox Olw2WInx87;
    private CheckBox LKD2gOUVsM;
    private CheckBox RCc2pvScMe;
    private CheckBox voL2aC2vmw;
    private CheckBox KhN2hRb4Q5;
    private CheckBox PKA2Ry0aIr;
    private CheckBox b9k26GOUks;
    private DateTimePicker e4C2UbMO1J;
    private DateTimePicker lmr2oUITYY;
    private CheckBox KR42rfyvEl;
    private CheckBox TAB2fYhitK;
    private CheckBox bs72KKHBEK;
    private CheckBox SUV2iHHi8j;
    private CheckBox UWW2zJKrxR;
    private CheckBox HnUT7Og2am;
    private CheckBox r12T9qiO1T;
    private CheckBox PlFTkTCVmB;
    private CheckBox mjtTQn5PGE;
    private CheckBox hIiTsjlZxq;
    private DateTimePicker eK4TJaX0QA;
    private DateTimePicker u2HTZUUu05;
    private CheckBox al2T5vXJnX;
    private CheckBox T82T814xrx;
    private CheckBox eIZTL4uJod;
    private CheckBox HlsT1QLeP4;
    private CheckBox EmDT2iJNv5;
    private CheckBox wCDTTd1TNX;
    private CheckBox DxrTl6mDbf;
    private CheckBox WCWTNvmCpk;
    private CheckBox pS1TVtpoIu;
    private Label xHkTtsEn5G;
    private Label eLkTM4teCN;
    private Label h1uTH5ONtJ;
    private Label UWbTvYi9kg;
    private Label yeaTcVRpBp;
    private Label cdiTjdMlod;
    private Label QOqTyi9viJ;
    private Label icPTSpsoio;
    private OpenFileDialog JyPTOGTBNh;
    private Timer IGgTqgcrAB;
    private TabPage WQRTXl8701;
    private CheckBox PFLTDUIa2b;
    private ComboBox RQ3TY6tIbs;
    private ComboBox zQDTFJwH4f;
    private ComboBox b1kTebQWil;
    private ComboBox MyvTd4lLZq;
    private ComboBox Bv3Tmydu69;
    private ComboBox l6kTPIylh8;
    private ComboBox lDZT3e50bB;
    private CheckBox BO6Txv8MlZ;
    private ComboBox myGTEIqyfQ;
    private ComboBox hiYT07hYyY;
    private ComboBox wS8TGVRU4I;
    private ComboBox BRRTA4bQ68;
    private ComboBox L78TCEejVM;
    private ComboBox mvYT4t55nI;
    private ComboBox SeWTncP0rM;
    private ComboBox nqlTwuilm9;
    private CheckBox OMKTu6urGW;
    private ComboBox fX7TIbM35g;
    private ComboBox z4GTBrsu2k;
    private ComboBox JpNTbIhuKe;
    private ComboBox YFbTWTlOGl;
    private ComboBox RHCTgPcmYo;
    private ComboBox jf4Tpx6p1y;
    private ComboBox vwVTawRoQp;
    private ComboBox yttThgD9rO;
    private CheckBox N7nTR19lY4;
    private ComboBox WIIT6jRuTS;
    private GroupBox oZLTUnE3Rl;
    private Label UAsToLO03a;
    private TabPage i5iTrD4LIF;
    private GroupBox u7XTf60emK;
    private GroupBox gbUTK2ncq0;
    private Label zwLTic9M38;
    private TextBox UB7Tz9sXbj;
    private TextBox lual7C67YQ;
    private Label bk0l9Lnnjk;
    private TextBox YQ3lkLxpNO;
    private Label BU2lQxOogQ;
    private CheckBox TBPlsUxfUG;
    private TextBox kOZlJ4YB78;
    private Label cwtlZaCU3T;
    private Panel B35l5fxD7B;
    private GroupBox XqKl8rdQWw;
    private TextBox zABlLjnXgX;
    private Label CV9l17fadg;
    private Label xtVl2ESlAg;
    private TextBox efFlTfOPSM;
    private TextBox Q0EllMYmiW;
    private Label HI7lNGCS3W;
    private TextBox j70lVXIm3W;
    private Label PFqltpA9qY;
    private CheckBox RnClMGRZG7;
    private TabPage wcTlHC4ugH;
    private TextBox Cu4lvk669Z;
    private TextBox VTBlcfe0Xc;
    private Label RHcljQMCeJ;
    private Panel VoplyNeKiT;
    private Label NfHlSf9f1j;
    private Label IDflOZ69SD;
    private ComboBox qPDlqNe566;
    private ComboBox pnIlXKp27D;
    private Button oJylDhYf2v;
    private GroupBox ATYlYKprgG;
    private LinkLabel baElFme7fE;
    private LinkLabel qIdlec07Ha;
    private LinkLabel M4Hldm4ede;
    private GroupBox t6YlmX40l2;
    private TextBox qirlPbtVcI;
    private ComboBox Blql3MrCN4;
    private Label EnHlxaAVbm;
    private GroupBox MBylEGWpnk;
    private Label tOMl0SiGJs;
    private TextBox KuwlGVXCBD;
    private TextBox yI5lAgl1oy;
    private Label LYnlCYR3h0;
    private TextBox rMSl46k0vl;
    private Label K27lntKnrR;
    private CheckBox Povlwu5t2q;
    private Label b9PlutbkN7;
    private ComboBox E0jlIPyxxR;
    private Button mRxlBZxUxZ;
    private Button VTllbTV2ta;
    private Label ayilWTxXXJ;
    private TextBox GURlglX4In;
    private TextBox yT9lpPRRtB;
    private TextBox WxclasZBFI;
    private TextBox iFblhTp8RO;
    private TextBox miClR6v7EZ;
    private TextBox KDGl6nRdEH;
    private Label O5plUIM6aZ;
    private TextBox r9vlohHOjK;
    private TextBox E3elrI84hw;
    private TextBox LbAlfnVIhh;
    private TextBox XrdlKv9CJK;
    private TextBox PKHlibWMWi;
    private TextBox b0wlzNGDRg;
    private Label AfJN7UTcoe;
    private Panel wQjN99mtuS;
    private TextBox TWvNk1dTaq;
    private TextBox v8fNQfSjCw;
    private Panel Hm7NspPZVQ;
    private TextBox EQoNJbrmeL;
    private TextBox dKqNZ3kyrt;
    private Panel sMNN5ws2Ij;
    private TextBox zMqN8mcN1m;
    private TextBox CHvNLV3GEw;
    private Panel b8TN1fT1AV;
    private TextBox gJCN2lbBOu;
    private TextBox VVpNTUoalL;
    private Panel dR4NlLQulf;
    private TextBox t9gNN9LaFQ;
    private TextBox uvUNVSrbLl;
    private Panel wYPNtgMkRP;
    private TextBox od2NMuFckY;
    private TextBox ow7NHTOupe;
    private Label fGnNv4HRNb;
    private TextBox jgkNcwdhbp;
    private Label rjONjKllln;
    private TextBox OaXNyJkVHE;
    private Label aTVNSefwsH;
    private ComboBox kwBNOL4yBB;
    private ComboBox ABaNqOaAYi;
    private ComboBox sElNXu3LUW;
    private ComboBox GSoNDn9XXe;
    private ComboBox s1PNYMpfeF;
    private ComboBox eVlNFXV40R;
    private Timer lp4Ne9KLDh;
    private BackgroundWorker AI2NdseWtp;
    private GroupBox PSyNmJebDK;
    private CheckBox IbJNP2FNuR;
    private TextBox SvZN3btgyx;
    private Label k1PNx72EJF;
    private TextBox BxZNEM9hpB;
    private Label sMQN0mqTb6;
    private LinkLabel NycNGNgCHG;
    private GroupBox UXbNAfpkf5;
    private Label MSfNCgJey4;
    private CheckBox t8BN46FHI0;
    private Label AB3NnZI1xs;
    private Label h7BNwqqSpV;
    private CheckBox pBuNuxRN5E;
    private ComboBox kjuNIvoh1Q;
    private Panel k08NBTVlb8;
    private TextBox zPkNbsoseN;
    private TextBox PsGNWLOk03;
    private TextBox orJNgaDcU5;
    private Label b19NpIrVQ8;
    private Label RhUNaseNwQ;
    private CheckBox JUnNhJpSXc;
    private TextBox q0hNRMblon;
    private TextBox VG1N61msNp;
    private TextBox iDxNUDyvY1;
    private TextBox rw9NoGk41O;
    private Panel K68NryybLo;
    private TextBox mUVNfRkBQD;
    private TextBox z51NKX1ETC;
    private ComboBox F4VNi7mnZv;
    private TextBox euONzU0oUR;
    private Label hRKV7Dxh2t;
    private TextBox LHaV9r5dVL;
    private Label uxyVkmWPoI;
    private TextBox YYaVQHpsPs;
    private Label Kg5VsK62Gk;
    private CheckBox dAVVJOWKJc;
    private Label dXjVZW16Sn;
    private Label r5EV5Q93iA;
    private Label q7EV84iPMO;
    private Label yy9VLGWnP4;
    private CheckBox jSAV1TWc45;
    private CheckBox YL2V2m3cAD;
    private CheckBox udoVTQHA7p;
    private CheckBox dbeVlnnEy6;
    private DateTimePicker q9gVN7AHhh;
    private DateTimePicker wvxVVnWEwW;
    private DateTimePicker zeXVtUn2lI;
    private DateTimePicker kg4VMGwlWc;
    private DateTimePicker tA9VHOqrqn;
    private DateTimePicker EOUVvg0vZy;
    private DateTimePicker hGqVcISjp4;
    private DateTimePicker V20VjgtODy;
    private CheckBox heyVypdDJZ;
    private CheckBox F9lVSrJuvK;
    private CheckBox q1uVOFBeEB;
    private CheckBox a1hVqW9tI2;
    private CheckBox ttAVXqDxi7;
    private CheckBox hjlVD1pLPZ;
    private CheckBox JwGVYrpPE4;
    private CheckBox ItBVFGKwCR;
    private CheckBox eEMVeyoENs;
    private CheckBox Q9LVdmMFRQ;
    private CheckBox UXqVmqYpvl;
    private CheckBox tBSVPIP9g3;
    private CheckBox JeMV30UXq2;
    private CheckBox HnlVxvdFW1;
    private CheckBox IEyVEOuy04;
    private CheckBox E51V0OSOa8;
    private CheckBox zcOVG5J4Zx;
    private CheckBox zpdVAviIyR;
    private CheckBox HPmVCCqq1o;
    private CheckBox rN2V42bjOa;
    private CheckBox wUSVn1SWJG;
    private CheckBox lTtVwTpeWF;
    private CheckBox q8YVuS9Q2J;
    private CheckBox E0IVIdsBht;
    private CheckBox zXnVBtINVr;
    private CheckBox h9CVbgUlR8;
    private CheckBox LpvVWSHklO;
    private CheckBox CfHVg1E2P1;
    private CheckBox xjdVpomFgy;
    private CheckBox u6eVa4d0FF;
    private CheckBox ljiVhV6UKw;
    private CheckBox uyFVRq0QO6;
    private CheckBox yTiV6J58es;
    private CheckBox yjSVULCUFK;
    private CheckBox zpcVo693B9;
    private CheckBox p9CVrXTiBe;
    private CheckBox Mc6VfwJJCv;
    private BackgroundWorker XFYVKo3gvm;
    private BackgroundWorker xxjVi9DNl6;
    private TextBox rAhVz7aLQR;
    private Label FJ4t703Lfn;
    private Timer yaRt97RQD3;
    private Timer uD9tkNryih;
    private GroupBox AUwtQ1cSWA;
    private Label l8Qts9K1KH;
    private TextBox maltJXccux;
    private TextBox GnstZ0EtxF;
    private Label FUFt5sW1ZC;
    private Panel k6Ct81osjT;
    private DateTimePicker M6xtLHNnCB;
    private DateTimePicker Wbbt1AwlUu;
    private Panel r2ut2XT9L6;
    private DateTimePicker Uw2tTWaLAB;
    private DateTimePicker pgCtlroVEl;
    private Panel FaKtNNbYRv;
    private DateTimePicker WjStVvfbFG;
    private DateTimePicker p9jtt5cVAY;
    private Panel HaXtMl4H6M;
    private DateTimePicker JGJtHaGjf1;
    private DateTimePicker stftvChJ89;
    private Panel GfdtcYuuIv;
    private DateTimePicker ljDtjAWjxI;
    private DateTimePicker PwOtyUfDjf;
    private Panel RNdtSqKVD8;
    private DateTimePicker e4etOuHoua;
    private DateTimePicker KqDtqQv5PK;
    private Panel KMTtX7Nqxt;
    private DateTimePicker ATmtDeyovC;
    private DateTimePicker AvotYSOix6;
    private Panel thxtFN2XgS;
    private DateTimePicker GiDteGqHSi;
    private DateTimePicker UCOtdYxgny;
    private Panel lp6tmvAI8d;
    private DateTimePicker NAutPvxtpp;
    private DateTimePicker Mhxt3UoVVg;
    private Button e6rtxvRQBi;
    private Label OxQtEbvvSV;
    private Label oTEt0oM5Or;
    private Label G8QtGtJJHZ;
    private CheckBox U82tAqdnVr;
    private CheckBox t88tCk2aNx;
    private CheckBox woct4aZ8Dh;
    private CheckBox DGNtn5rGyy;
    private CheckBox OMXtwFKCO7;
    private CheckBox eqytuCM4vn;
    private CheckBox QG7tI6Wmer;
    private CheckBox gYatBDUJhL;
    private CheckBox n0StbLmtVr;
    private CheckBox K2UtWG8xU7;
    private ComboBox gdBtgaiVPK;
    private Label WXWtpvQKZG;
    private Button DeOtan7dsl;
    private CheckBox SsTthbjlEI;
    private Label cRZtRHXjha;
    private Panel y3it6Roboy;
    private TextBox lRntUiABJY;
    private TextBox uodtogiPEQ;
    private ComboBox umktrMIjHE;
    private Panel oWptf1wq3n;
    private DateTimePicker dlQtK6ppKo;
    private DateTimePicker Vf6tiLVeZI;
    private TabPage dEstzLgxAS;
    private GroupBox N4kM72xl39;
    private Button QZXM95hwRN;
    private Label zcNMkU7YVt;
    private CheckBox KydMQSp2a7;
    private Button NKTMsnYCfL;
    private Label a02MJFPIVi;
    private GroupBox x66MZ879ff;
    private Label gDZM5CLQ8D;
    private Label RKfM8OY0wp;
    private TextBox vGZMLITwVR;
    private Label GV4M1FtDwn;
    private TextBox tGUM2dEKDe;
    private Label D8bMTULB9x;
    private TextBox Vy3Ml7Y2LW;
    private Label UZ0MNKX31u;
    private TextBox YilMVORxWC;
    private Label BbQMtkA8JR;
    private TextBox WpVMMi8QuD;
    private Label uytMHiA2rv;
    private TextBox osfMvkYe3Y;
    private Label cpUMcWIyFN;
    private TextBox rG3MjBlO2H;
    private Label GE0MyLI8hY;
    private TextBox RXAMSkoDjj;
    private Label M6bMOy7yp7;
    private TextBox gOiMqqCegA;
    private CheckBox vQNMXrrNnY;
    private Label HGvMDG6CQd;
    private CheckBox JQPMY1DvCS;
    private TextBox sfpMFTDctk;
    private TextBox g4YMevUDUp;
    private TextBox SSSMdP3VvT;
    private TextBox gDpMmJOgI8;
    private TextBox jZ0MPAgNMO;
    private Panel VOKM375e4c;
    private TextBox cREMxvtG53;
    private TextBox AN1MEJkc86;
    private ComboBox icCM0LwDEZ;
    private Panel sFfMGg6x8G;
    private DateTimePicker c52MAD0Au4;
    private DateTimePicker p6XMCdGScZ;
    private TabPage SDFM4GQtkq;
    private CheckBox d4KMnunZSl;
    private Label UGJMwUpkQv;
    private TextBox mkjMufhDrB;
    private Label UnhMIrkqTH;
    private TextBox hJOMBI0KEZ;
    private Label PPKMb0rHgy;
    private TextBox NrxMWx5aq7;
    private Button dw2MgyBy4A;
    private Button f3XMpKLQRs;
    private Button YWAMaU0HiU;
    private CheckBox QTJMhJnuUL;
    private CheckBox DP1MRtC5VC;
    private Button NgcM6qtUWR;
    private CheckBox u0kMUKvhXv;
    private CheckBox xhdMo1UDiI;
    private CheckBox WYGMrMATyQ;
    private CheckBox jfAMf2EWOe;
    private Label kZLMK2mARt;
    private TextBox bvJMi0OLrm;
    private GroupBox xx2Mzemywg;
    private Label rgLH7ryFPV;
    private TextBox v2XH9UmhZc;
    private CheckBox PV0HkmKtR6;
    private CheckBox j0LHQ97mhu;
    private CheckBox o4eHsEmjH2;
    private CheckBox yfhHJdqxle;
    private Label Qr5HZaE6YC;
    private CheckBox sHVH5ka1B1;
    private TextBox PGAH8LoLc5;
    private Label JtdHLmprYw;
    private ComboBox SepH1CbO74;
    private CheckBox yOwH2coifW;
    private CheckBox o6HHTM76gC;
    private CheckBox WHmHlwjNqM;
    private CheckBox xscHNYJOfk;
    private TextBox FhpHVcU7RX;
    private Label BEcHtZaOy8;
    private TextBox KgJHMuejls;
    private Label ShBHHNFduW;
    private TextBox HcGHvVB3Lu;
    private Label PYnHcdAmma;
    private TabControl DfPHjQPgDK;
    private TabPage a8QHySr4RL;
    private GroupBox tcBHSdHZjk;
    private Label JvrHOhjka6;
    private TextBox BtUHqOUQZA;
    private Label V2ZHXsEh5v;
    private Label fPXHDEaVMq;
    private CheckBox vAGHY9dWH6;
    private CheckBox IcAHFHrcrG;
    private CheckBox av0HenYVlS;
    private Label XmrHd6PpUL;
    private CheckBox fFYHmgnI1x;
    private CheckBox BjrHPdpAeX;
    private CheckBox GsoH3UAuxb;
    private Label knZHxUWLuN;
    private CheckBox bWJHElALAT;
    private TabPage MSSH0K0cv3;
    private TextBox nQgHGDooy2;
    private CheckBox o40HAdyV26;
    private TextBox RYWHCgd71K;
    private CheckBox qE6H4BMKm2;
    private TextBox oJBHnkEmNg;
    private TextBox IHoHws5AXw;
    private CheckBox OaRHupkgUr;
    private CheckBox dk8HIqaAKk;
    private CheckBox hoJHBsxwh3;
    private CheckBox MKZHb4R8Aw;
    private TextBox vUBHWSTbH2;
    private TextBox sxwHgAw5eV;
    private TextBox qtGHpJbFFg;
    private TextBox NCwHa9Ug7w;
    private CheckBox YT0HhP3icY;
    private CheckBox e5fHRKXVAB;
    private CheckBox bUlH62QZBE;
    private CheckBox kftHUGHqX5;
    private TextBox thIHowtsst;
    private TextBox uhEHr8K5xw;
    private TextBox Ij2HfgYa0Q;
    private TextBox DO7HKt09QJ;
    private CheckBox gImHiDMyZE;
    private CheckBox mLuHz1rAf3;
    private TextBox fHGv7QSj3i;
    private CheckBox FsXv9jxlE5;
    private TextBox XwpvkTn0co;
    private TextBox VFHvQr6WFJ;
    private CheckBox Y0QvsFwe8s;
    private TextBox FZSvJ6WiUh;
    private CheckBox ajUvZKKPFc;
    private CheckBox nP8v5h0NKE;
    private TextBox vJhv8BgHUn;
    private CheckBox bqwvL1sA2B;
    private TextBox bhYv1xFr4x;
    private CheckBox Lmdv2sx9py;
    private NumericUpDown hGtvTnFnAh;
    private NumericUpDown kLYvltdQBf;
    private Label LbgvNmWIYu;
    private Panel fkAvVsA446;
    private ComboBox zvmvtcxioZ;
    private CheckBox wBpvMJ2xqD;
    private Panel DaSvHI2mVm;
    private ComboBox DHfvv56GvX;
    private CheckBox BCUvcs2xwc;
    private Panel N06vjB3Fe4;
    private ComboBox HfQvysCIXp;
    private CheckBox DqAvSGMOxZ;
    private Panel P4HvOOfSae;
    private ComboBox BUKvqt1mSE;
    private CheckBox diKvXxUDsn;
    private Panel m2pvDPrgwb;
    private ComboBox fFNvYyKICs;
    private CheckBox FuOvFPZWO1;
    private Panel nM8ve5gk6G;
    private ComboBox RVIvdp20o5;
    private CheckBox mIyvmxDnaL;
    private Panel O7lvPDGTVe;
    private ComboBox TUpv3aRL1C;
    private CheckBox OObvxWqKO6;
    private Panel mAjvEsL7S4;
    private ComboBox WSiv0D8sDt;
    private CheckBox hl4vGoyoXI;
    private Panel QEIvAFeL3R;
    private ComboBox LHdvCErhui;
    private CheckBox kOuv49pR6g;
    private Panel l2fvne1enj;
    private ComboBox RJdvwkt1Oe;
    private CheckBox n5FvuYgTW3;
    private ComboBox cVlvIRjjbv;
    private ComboBox funvBrAeQM;
    private ComboBox FhXvbWLaqt;
    private ComboBox MeFvWIfGNr;
    private ComboBox Xgavgh4Y1o;
    private ComboBox bXdvpMV9Ht;
    private ComboBox NDMva6FLZf;
    private ComboBox bWBvhm3aoK;
    private ComboBox R0BvROIG4H;
    private ComboBox LOGv6IX824;
    private NumericUpDown K47vUQLxDK;
    private NumericUpDown VoXvoDh98I;
    private NumericUpDown ynKvrg5olL;
    private NumericUpDown MDHvfu2Pye;
    private NumericUpDown eVZvK6t1A2;
    private NumericUpDown SIRviEh4yr;
    private NumericUpDown RrTvz9eVHY;
    private NumericUpDown OQlc7Yjn5l;
    private NumericUpDown aIOc9BpZcn;
    private NumericUpDown HxgckPGjUI;
    private CheckBox thUcQ9HATH;
    private Panel PtBcsyek0v;
    private DateTimePicker DfNcJSh1al;
    private DateTimePicker dfDcZvJtCS;
    private ComboBox tJYc5LYuQ5;
    private Panel du4c8Z4MRL;
    private TextBox x3rcLFD0FH;
    private TextBox Ag4c1HfJVC;
    private Label PdGc2oR3Tw;
    private Button EMscTfIMeQ;
    private TabPage cSdclrorqv;
    private CheckBox RhjcN1FEA1;
    private NumericUpDown MvJcV3jRWu;
    private Label NBfctBSA61;
    private NumericUpDown apGcMRZhQG;
    private Label nGhcHX8890;
    private Panel i4Vcv0yAhf;
    private DateTimePicker M95ccJllHT;
    private DateTimePicker zSacjFcCbH;
    private ComboBox OfdcyZkVpb;
    private Panel a5gcSuqfR7;
    private TextBox t4GcOVClsP;
    private TextBox lo3cqb6srO;
    private CheckBox rQZcX39xdt;
    private Label o4ucD3UF6r;
    private GroupBox p3ocYw5l55;
    private CheckBox iSlcFEZJrF;
    private TextBox eRhceBHdqM;
    private Label PD3cdBM9jR;
    private GroupBox SJ6cmboGd5;
    private CheckBox xIWcPpDSti;
    private GroupBox rvCc3qca8E;
    private CheckBox JdUcxd7rfc;
    private Panel YZ1cEX0SVX;
    private Label geYc0wFiBG;
    private CheckBox N7hcGwwk6b;
    private TextBox wgscAYdsfO;
    private CheckBox ojycClxUNL;
    private Label V66c4cBGdu;
    private TextBox MCTcnON5AO;
    private TextBox KgWcwoMbW7;
    private Panel e1mcuFopBS;
    private Label i5ccI0ULkx;
    private CheckBox PkbcBWX2t3;
    private TextBox WK3cbV0ilI;
    private CheckBox PrkcWFDpMr;
    private Panel INxcgKHjEg;
    private Label DhZcpdcTc6;
    private CheckBox mDdcakiUpC;
    private TextBox RXichw0jU8;
    private CheckBox BKZcRELEtl;
    private Label KCVc6KkFAh;
    private TextBox PYrcUwVtdE;
    private TextBox XvicojZKs4;
    private Panel OkEcraWl07;
    private Button A1hcfFBTwk;
    private Label TwMcKkvBkd;
    private TableLayoutPanel PsociIwPxv;
    private DateTimePicker aLBczgeqbV;
    private CheckBox he8j7I7fkF;
    private TableLayoutPanel p5Aj9moLK8;
    private Panel RsCjk6NRjd;
    private NumericUpDown IOajQtjuR5;
    private ComboBox OhcjsV5rgn;
    private ComboBox um2jJ6gcvY;
    private CheckBox rL1jZoJy7V;
    private Panel HQnj5ZZC8f;
    private NumericUpDown pXWj8Dg9IT;
    private ComboBox vttjLMYatO;
    private ComboBox ysNj1sIq6t;
    private CheckBox Cc4j21MZG6;
    private Panel r4bjT0lFdf;
    private NumericUpDown FEWjl4MOLn;
    private ComboBox G22jNffgCx;
    private ComboBox zB4jVw1pRG;
    private CheckBox DIZjtoo0Zd;
    private Panel EtRjMr3W6Q;
    private NumericUpDown qRkjHFuur8;
    private ComboBox bRXjvnOSi0;
    private ComboBox udljcU3Mnx;
    private CheckBox jWMjjCQIF0;
    private Panel cEtjyOtQmu;
    private NumericUpDown TFZjSM7SP4;
    private ComboBox QwpjOXJGcO;
    private ComboBox VCcjqZv1iB;
    private CheckBox jONjXMjMQe;
    private Panel ILLjDS8LIt;
    private NumericUpDown l7OjYDNYQO;
    private ComboBox jsbjFulc0n;
    private ComboBox IjMjeHY0yb;
    private CheckBox nH1jdKC5Jb;
    private Panel C58jm65kx0;
    private NumericUpDown agEjPLsk97;
    private ComboBox uT5j3hSVQt;
    private ComboBox YJgjxuCml4;
    private CheckBox MDjjEjHHTl;
    private Panel YQpj09avqN;
    private NumericUpDown M9KjGhBbJ2;
    private ComboBox IPsjAIjVRY;
    private ComboBox W6XjCWLV8c;
    private CheckBox P5Aj4JCGcv;
    private Panel EDWjn64tQn;
    private NumericUpDown spSjw9PHLG;
    private ComboBox Oh0juxywmg;
    private ComboBox uTPjIFQYvw;
    private CheckBox bFhjBdykAo;
    private Label BkLjbPe2y4;
    private Label CONjWKKEhp;
    private CheckBox cwnjgigZ5A;
    private CheckBox kkfjpi5XG9;
    private CheckBox JwwjaLkRjD;
    private CheckBox jZujh8TWiY;
    private CheckBox jMVjRjJ3yQ;
    private CheckBox BrPj61YyHQ;
    private CheckBox GKWjUFmO5m;
    private CheckBox EbkjoHxiUb;
    private CheckBox btQjrryxoY;
    private CheckBox MWfjfJjAg3;
    private Label mIYjKVuhoF;
    private Label f7IjiAuxsL;
    private Label PBCjzISSx0;
    private Label gw5y7860uR;
    private Label igIy9cveOF;
    private Label mPgyk4G7MI;
    private Label LnJyQ9DpBm;
    private Label tN0ysO5gaO;
    private Label zJlyJk0Crp;
    private Label CPIyZMlFYP;
    private Label T8Ny570AVT;
    private CheckBox UdQy872u1i;
    private DateTimePicker BQPyLCwoyI;
    private DateTimePicker nO1y1WaxF9;
    private CheckBox Sdpy2socl8;
    private CheckBox c8cyTNtrZm;
    private CheckBox BRhylX3kHG;
    private CheckBox ImuyNV2lnJ;
    private CheckBox CTdyVl3xk2;
    private CheckBox YZDyt4y5m2;
    private CheckBox HkTyMB6sYm;
    private CheckBox qPwyHMZhev;
    private CheckBox A0PyvDocCB;
    private CheckBox pABycKC9AG;
    private DateTimePicker rDkyjPBE2Y;
    private DateTimePicker La4yyu95dD;
    private CheckBox AOCySqvcWh;
    private CheckBox g8XyOwMgrb;
    private CheckBox m5MyqGWvYn;
    private CheckBox LRlyXSSlWJ;
    private CheckBox qejyDsXxJS;
    private CheckBox a14yYgGJiX;
    private CheckBox uwNyFquxlU;
    private CheckBox CbQyeQKvfi;
    private CheckBox kw0ydlCqCF;
    private CheckBox IDtym9Etfn;
    private DateTimePicker RGIyPG0Ie7;
    private DateTimePicker eaWy3k0vRu;
    private CheckBox rdNyxLA138;
    private CheckBox zaNyELwYu7;
    private CheckBox K1ry02UCXW;
    private CheckBox A8QyGfaAYh;
    private CheckBox GfKyAX1nnu;
    private CheckBox PPRyCRYNSb;
    private CheckBox iYLy4cVAqG;
    private CheckBox W26ynr2hJD;
    private CheckBox h89ywyvjD2;
    private CheckBox wtryuRiZKm;
    private DateTimePicker C7uyIDbAjV;
    private DateTimePicker FHCyB7790Z;
    private CheckBox KkEybmTKHI;
    private CheckBox niCyWjTR81;
    private CheckBox jQyygXc2ea;
    private CheckBox Pr2ypdQTXl;
    private CheckBox GcLya6Tn3m;
    private CheckBox z1pyhiYEH2;
    private CheckBox bckyR09Ulm;
    private CheckBox fcGy6x2jKl;
    private CheckBox aAkyUSEk0F;
    private CheckBox IlUyoQTKrZ;
    private DateTimePicker QOCyrw0Ini;
    private DateTimePicker m5FyfwIJ1U;
    private CheckBox YuRyKDe7rR;
    private CheckBox EWSyiHRnD4;
    private CheckBox lvYyzvUB3u;
    private CheckBox nJvS7lynxP;
    private CheckBox crKS9LOXwm;
    private CheckBox XBKSkQscXv;
    private CheckBox nZ2SQg7Jik;
    private CheckBox DpKSsIuI2U;
    private CheckBox Yj7SJvTSkX;
    private CheckBox AUESZo18Zb;
    private DateTimePicker Su9S5AiFub;
    private DateTimePicker fRIS8Riiyx;
    private CheckBox yuiSLyKBsP;
    private CheckBox d4eS1fejZJ;
    private CheckBox dPiS22xfH8;
    private CheckBox JO6STsJpTM;
    private CheckBox zTrSlSCO3h;
    private CheckBox BqhSNDEGKI;
    private CheckBox CNwSVbulEK;
    private CheckBox Sr3StN2uOd;
    private CheckBox W7TSMGlQFE;
    private Label tPOSHL2LO6;
    private Label m4fSvJkcOL;
    private Label dd5ScNloRc;
    private Label GMtSjKYKBE;
    private Label O9sSyS8a4c;
    private Label qhVSSAgjYh;
    private Label JXjSOK1i3A;
    private Label AxJSqApmq4;
    private Label JwaSXhEMea;
    private Label o7vSDEW3TT;
    private Label YLISYGlC2d;
    private Label SbHSFLaVKK;
    private CheckBox niBSeC7Dso;
    private CheckBox ugeSdViG6b;
    private CheckBox bMSSm5dQrw;
    private CheckBox ecYSPbfumC;
    private DateTimePicker CZ0S3IoGp6;
    private DateTimePicker jJcSxODVUE;
    private DateTimePicker UpVSER86SR;
    private DateTimePicker WgAS0tUCZp;
    private DateTimePicker CNCSGw2Jeu;
    private DateTimePicker D9lSA0Aqjy;
    private DateTimePicker kH9SCbNouL;
    private DateTimePicker AykS4eedE6;
    private CheckBox a31Snp9dO7;
    private CheckBox LBNSwhfREy;
    private CheckBox TsESuN7UWv;
    private CheckBox FmUSIXgIem;
    private CheckBox FlTSBUACJL;
    private CheckBox G1LSbta5as;
    private CheckBox dOOSWeQj7T;
    private CheckBox kEmSg3ZDfA;
    private CheckBox F4USpyWeN7;
    private CheckBox Mg5SaSWSha;
    private CheckBox Wd7Sh3dkiL;
    private CheckBox YvPSRgsuJt;
    private CheckBox CLGS6Bg26J;
    private CheckBox kuaSUTfxcV;
    private CheckBox P2RSok0IxJ;
    private CheckBox LWZSrTH1PY;
    private CheckBox pOcSfIeKYS;
    private CheckBox O58SKvhUWa;
    private CheckBox vi8Si38LYe;
    private CheckBox aw6SzlbAgc;
    private CheckBox JjOO7PElbh;
    private CheckBox HgGO9OEBRT;
    private CheckBox IUCOk06SHw;
    private CheckBox gMeOQ4nRNE;
    private CheckBox nwSOsHloOS;
    private CheckBox Vx8OJDGvYb;
    private CheckBox HdKOZrdYZf;
    private CheckBox ROuO5kHsGK;
    private CheckBox jjTO8oLS0j;
    private CheckBox g14OLpd3i6;
    private CheckBox XVnO1HpLXg;
    private CheckBox eIuO2RREbd;
    private CheckBox MqROTomr55;
    private CheckBox QMCOlfUtAq;
    private CheckBox WU4ONZbDbW;
    private CheckBox zx8OVDpWRZ;
    private Panel hEXOtaHSsJ;
    private NumericUpDown USgOMeHUC9;
    private ComboBox we0OHZpRpS;
    private ComboBox Di6Ov9VGjP;
    private CheckBox Y8jOcB7hYF;
    private ComboBox vxQOj1wdhQ;
    private TextBox dIqOyfCyl2;
    private TextBox ME7OS3DX83;
    private TextBox ViQOO6OsWJ;
    private TextBox LikOqaYGke;
    private CheckBox XyNOXSs3iW;
    private Panel C9AOD7CZTg;
    private TextBox uRCOYb6RKi;
    private TextBox lGbOFWeKKV;
    private Panel KAVOe1UdKg;
    private DateTimePicker JQ1OdQo7gx;
    private DateTimePicker NtrOmI83WZ;
    private CheckBox b5eOPwPjOk;
    private Label xP5O3K3Gfh;
    private NumericUpDown nJ6OxRU4nb;
    private Label xOiOEvq2yB;
    private ComboBox cQHO0XUXyP;
    private TabPage gaQOGN7dH3;
    private GroupBox YnLOA1jPjo;
    private CheckBox PTkOCfPcKu;
    private CheckBox lG7O41TKfI;
    private Timer YAYOn5CBI8;
    private Label WrkOwIB43p;
    private NumericUpDown LFlOuprVhR;
    private CheckBox QsfOIH8XTp;
    private CheckBox s43OBauVaE;
    private CheckBox XL2ObCX1Jb;
    private Panel QYDOWkSfWU;
    private Button ClvOgBL9I9;
    private Label Hy3OpiUu5b;
    private GroupBox E83Oa54oSY;
    private Button TwkOhJPQSl;
    private Button olPOR2ne73;
    private Button RRhO6Q9poS;
    private Button ylqOUYdIl3;
    private Label iniOojHhqv;
    private TextBox dF4OrdTsNK;
    private TextBox XYpOfhcYP4;
    private Label IB5OK9p4gj;
    private TextBox SfIOi3xV0W;
    private Label jG7OzhuplZ;
    private TextBox mn2q7k18ni;
    private Label mAJq9KUnNH;
    private CheckBox RAnqk0fcdK;
    private TextBox fpuqQGROuX;
    private Label SbXqs5fmK3;
    private Label QFkqJ5g3rs;
    private TextBox AMRqZPZBsm;
    private Button U2dq5uAmmJ;
    private TextBox lOWq8YmELb;
    private CheckBox G3JqLtuAKd;
    private TextBox DiHq1Z7Bsa;
    private TextBox Nebq2Y7nL6;
    private TextBox VfNqTZ0w7I;
    private TextBox D98qlfUsc6;
    private TextBox xIQqNNlyU2;
    private Label jPjqVPetrg;
    private ComboBox X9vqtNDFvc;
    private TextBox oxsqMGwh9u;
    private Label lreqHadnO6;
    private Panel N1dqvOLntL;
    private Label et2qchpGpK;
    private Button Gckqjj9b7Y;

    [DllImport("wininet.dll", EntryPoint = "InternetSetOption", SetLastError = true)]
    private static extern bool SwwsBSCURZ(
      IntPtr _param0,
      int _param1,
      IntPtr _param2,
      int _param3);

    [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool InternetSetOption(
      int hInternet,
      int dwOption,
      IntPtr lpBuffer,
      int dwBufferLength);

    [DllImport("kernel32.dll")]
    public static extern bool SetProcessWorkingSetSize(
      IntPtr handle,
      int minimumWorkingSetSize,
      int maximumWorkingSetSize);

    [DllImport("urlmon.dll", EntryPoint = "UrlMkSetSessionOption", CharSet = CharSet.Ansi)]
    private static extern int uaRsb60fOy(int _param0, string _param1, int _param2, int _param3);

    [DllImport("wininet.dll", SetLastError = true)]
    public static extern bool InternetSetCookie([MarshalAs(UnmanagedType.LPStr)] string Url, [MarshalAs(UnmanagedType.LPStr)] string CookieName, [MarshalAs(UnmanagedType.LPStr)] string CookieData);

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static StringBuilder GetUriCookieContainer(Uri uri)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SetUriCookieContainer(string URL, StringBuilder sb)
    {
      // ISSUE: unable to decompile the method.
    }

    [DllImport("wininet.dll", SetLastError = true)]
    public static extern bool InternetGetCookieEx(
      string url,
      string cookieName,
      StringBuilder cookieData,
      ref int size,
      int dwFlags,
      IntPtr lpReserved);

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IAZsWHBBDD()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void WndProc(ref Message m)
    {
      // ISSUE: unable to decompile the method.
    }

    [Category("Behavior")]
    [Description("Specifies whether to allow the window to minimize when the minimize button and command are enabled.")]
    [DefaultValue(true)]
    [Browsable(true)]
    public bool AllowMinimize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        // ISSUE: unable to decompile the method.
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        // ISSUE: unable to decompile the method.
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void THysg0NPE7(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aDJsp6TDCN()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void eOXsahtRSC(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReBot()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeFormLanguage(Localizations newLocalization)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Cc6shaXoc0()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ofvsR1UChh(object _param1, WebBrowserProgressChangedEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int xwIs6v2kPj(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CYbsUFQlD4(string _param1, string _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void XuGsoTl5Ex()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IWfsrKd7nK()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mo2sfgFVZK(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void D7dsKykNQK(int _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JiWsi7ot1k(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool oErszL8YRP()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ianJ7UeQjD(bool _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void O0WJ9oGqXH(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void vetJkN5Hhx()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string LDZJQJWKyo(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void om7Js5n9FS(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HemJJtUreW(string _param1 = "")
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string Q6hJZVOEB1(MD5 _param0, string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveControls(Control ctl)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReadControls(Control ctl)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QLYJ5ulxDp()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TsDJ8cGiWP()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteCookies()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rV5JLeUw40(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool M1SJ1PQZ4a()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BDwJ2uI8h8()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CleanReBot()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void afhJTo663J(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void eajJldBHUp()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UsNJNgcEeU(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void E7NJVjSCMy(string _param1, PostURLAction _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void YbHJtyRkVD(string _param1, byte[] _param2 = null)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void oNgJM6LJtK()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void A7tJHu0Cb1()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void cS1JvuO5se()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object GetPropValue(object src, string propName)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pthJcYAnX7(object _param1, WebBrowserNavigatingEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void bvBJjDc9Kw(object _param1, WebBrowserDocumentCompletedEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void hk5JybJyiK()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool JOmJSKQAQE()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CD9JO0WSwf()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iPZJqcTD9P(string _param1, string _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pBGJXlhxJC()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string yyXJDJGLYk(bool _param1 = false)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wA0JYaNq0Q()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ErrorLog(string msg)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool QIPJF1WIwD(string _param1 = null)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pgeJe5rCJf(string _param1 = null)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void m33Jd1IuUp()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool nD9JmIodhy()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GLZJPy0U2k()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void eWTJ3fI8jI()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void kEGJxmVpqV()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ND7JE2nWZH()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool q5cJ05ggLv(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int VNNJGeOIj2(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool oRmJASYaYx(bool _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LPTJCnHkI4(WebBrowserDocumentCompletedEventArgs _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gG7J4KuxsQ()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LyLJnlLyQM(ReBot.ReBot.PlayerInfo _param1, string _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lTUJw8ONPO()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void oUAJuMRQST()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PM8JI2DPp1()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool HtcJBU5agn()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool E0aJb8Uxkp()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ifBJW4iEhk()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void H0AJgIWFLg(string _param1, int _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool BMvJpbJisF(bool _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool fGcJam3Y8G()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool gkrJhhGOWM()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int zWnJRfZBZJ()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lZ7J6m6sbd(WebBrowserDocumentCompletedEventArgs _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string njRJU08Y5O(string _param1, string _param2, string _param3)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool QwtJok0mrh(TimeSpan _param1, TimeSpan _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool AbuJr2MGy1(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KckJfWJiZb()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rZwJKV1cia(int _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void o4PJidfg40(int _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool rnfJzSabW4()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string CreatePassword(int length)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dkTZ7LhULP()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool vI0Z9R8M9q()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool YuaZkfeNxt(int _param1, int _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CkdZQD9NfX(int _param1, int _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool MHAZs1Fli0(int _param1, int _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OwLZJiunli(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void kY6ZZi5XLv(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void F82Z5BpyEq(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void c03Z8s8TCR()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int r7OZL87gOj()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int fL6Z1uJ1PK(int _param1, int _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void E6AZ29Zvap(TextBox _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int RandomFromIntArray(int[] numbers)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int[] StringToInts(string myString, char? delim = null)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int[] StringIntervalToInts(string s)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] StringToStrings(string myString)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gRSZTpylOR(object _param1, MouseEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jsQZlUeDS4(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddLog(string Action)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JQGZNl9sbM(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void qENZVSISiv(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void YivZtNiLji(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ww7ZMbcIXU(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HiFZHBC2UP(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PS9Zvwike5(object _param1, FormClosingEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SZwZcZbG9o(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void eFwZj3IxHV(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EC1ZyQGWcf(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rDbZSfnrPt()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rckZOUjwot()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wL4ZqwPaEa()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dwGZX9VjrE()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NaiZDeAUg6()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void qs9ZYyW49Q()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BAMZFEftXt()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OyhZejAJcY()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SY3Zdbnur3()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JO2ZmZDM5G()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApaZPJmEdE()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Y6UZ30fnIP(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KlvZxqGLlF(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WiJZEvcDOa(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void hPwZ0GOylm(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BIDZGPMmGL(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void YFQZAdJGBW(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void tmlZC3UCsU()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gNYZ4bZskL(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void h1xZn9FjXS(object _param1, MouseEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string Hs8ZwcYWLs(string[] _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void O0vZu7aF5r(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Ek9ZIyNXDW(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rHaZBnjAda(object _param1, LinkLabelLinkClickedEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void K1QZbi842J(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string tuNZWhbI9J(ComboBox _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RvjZgjk0ch()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KuHZpvvRLJ(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CDlZaeDKc7(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void onsZh1dHn6()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pQCZRrGWVN(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void nFwZ6orXEu(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int zNlZUEtEVb(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IWGZokM1Rw()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EZ5ZrEuH4h()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RN3Zf6PjjE()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void bq6ZKXGl2k()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jFXZiq3LnR()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void g7NZzKhrPC(bool _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string in157UFQYu(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string Pa35958FrF(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void vSo5kkPUJJ(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HYx5QvDfDZ(object _param1, DoWorkEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void usx5sQRs9c(object _param1, RunWorkerCompletedEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WqJ5JAyOFh(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NJR5ZuLfFL(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QGM55TOPLR(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Uu158TVAwD(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void qix5LIhw9l(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void WriteCookiesToDisk(string file, StringBuilder cookieJar)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static StringBuilder ReadCookiesFromDisk(string file)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Cqg51PNufr(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void uHu52GP4lk(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pFQ5TCA81M(object _param1, MouseEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PT95laQ3ib(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void yhG5NP4wUi(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color HaA5VAlZuP(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void W9D5tJ28V2(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<Control> Concat(
      Control.ControlCollection col1,
      Control.ControlCollection col2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void E7j5MKojlh(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JQn5HtyL2v(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void vNP5veCEZa(object _param1, DoWorkEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IN45cmeWfP()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gQ25j2Gilb(object _param1, RunWorkerCompletedEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ee55yYBDAH(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QlQ5SuKvh6()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zBI5OPraO6(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PDw5qudYgV(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RCt5XVguM0(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void vUx5D4sGus(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lIK5YSZvHa(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UpdateReBot()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void d215F4f6WF(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FXt5esdTg8(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void uMa5dVP2Sy(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void N6Y5mrnjvi(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dp15PhTmBl(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Xu053HEjeQ()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IHm5xShXtS(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Point GetOffset(HtmlElement el)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void J375E1IOwg(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void neX50Solvj(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PHv5GwN48y(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void sfQ5AUXWRs(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WEW5CohCOg(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SkZ541ZQNU(bool _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Npi5nPdbAD(bool _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void qLE5wGIYAU(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void X0D5utAnc5(bool _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool jWN5Iy90Wp()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iqL5BDEE3L(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string D6U5bSUhad(string _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void vgq5W9snFd(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void cJb5gsnGo1(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void W2n5p2kw2x(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void bmZ5anDQLp(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OXX5h8pHZV()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aaG5RCoyfM(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void so156FINFj(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReBot.ReBot.AsyncTask<R> BeginTask<R>(ReBot.ReBot.AsyncTask<R> function)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Xie5UhdorT(object _param1, DoWorkEventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IIn5oryt7B(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void m2s5rNemMx(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Gpm5f70cpe(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jF75KgqlZl(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wkd5if2KsP(object _param1, EventArgs _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReBot_Disposed(object sender, EventArgs e)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeAdditionalTranslations()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OCE5zrScC1()
    {
      // ISSUE: The method is too long to display (68845 instructions)
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ReBot()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool xEFOhDoq9fo0Q8nSj2R()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool M3fMynolOkf6IpXOwmO()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static FormWindowState iq3BXmowirfAdZWw7L7([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object fnP7nLotw7DCn16sNyd([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void EcnwtdoWQdqKAmiqMiR([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void xR6udrokVth7vroBVuu([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object kQLSoBo3IQiArPSHIGV(int _param0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object uTfrptoTxcfcK7HyYZh([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void CDACvqoYf9MKRAm4GF4([In] object obj0, [In] FormWindowState obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object dRbMEqoS62PxinQIEit([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void dxooc6ocELpUFayVoRB([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void hKTatRo6TLXDyIjXuZM([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void jE4ia9oba2FkFAPBtH2([In] object obj0, [In] DockStyle obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void QyAFZQo7EyQNASDtDnK([In] object obj0, [In] Padding obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void at0LN0oKuLJEt53aIbi([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void b77aiyopKgqgfwJAFM8([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void viAnOco2ucQ5BmjQZ4P([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void WgEPWhogTl4yNUNVt5D([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object B0BgKboCOdkQ4NOVtaT([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void A3iZIsoiLqEKmxZM05V([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object IUFV6voMN2xqTuUNknF([In] object obj0, [In] object obj1, [In] object obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DialogResult gwBOTpoBFp8nrpk6Phu([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool ODIN4Do5EEU1KF5wBZa([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object exV2xsoVfYpRJd8Pur3([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object dFUr0loDqNmuQj8DIrA([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool HOj6HIoRJVr4JXCjk95([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void bbIp2GoNiBDPoofmZyy([In] object obj0, [In] object obj1, [In] Rectangle obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object BfK03oonufNVouDV5vf()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object Cy2d3nohlhlHyDVtwvS([In] IntPtr obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void EmDoR8o8LKLmDkhGcIJ([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object P58AFRoa1HIB22H6xFL([In] System.Type obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void skO242oPwqVlxblTEhp([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void d2kCYKoAXmEEOtcrTUe([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object qV12Qto1dwRZtTB6jlh([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object KpNF2jo4nWhil2rrwPa([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object WTy6sCojGt0RmTD2nT3([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void UQ4akVoL9P4dLwS2K2c([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void jFT9oBomLUNy9JhvvpG([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void WWTwVAoHlTB5xB5t5aK([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object X0I2DQoXnAN3fJXN8HO([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void LReWEsoJjYXrr4nuoWH([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object pfZhO5ofUEhrgdVQPD6([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object Ki5P8Co9dKV0Llc0LUe([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object No9abJozLD5D1RmfpD7([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object AyebjjQsQq0jprbaaQj([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool PBx1YcQyiPdnlAoyryK([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object Oi7GEMQdvFbrZmLxNO0([In] object obj0, [In] object obj1, [In] bool obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object JwJfN9QIUdQw5A8BG70([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object tPva9nQon8ZpB7pemcN([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object B59mG5QQmWpr5RTt76x([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool RK8laeQUr1bnjWSB9wa()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object Ta3wX9Qr2cktbiWVb7h()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object ot69rPQZMrLVDN3TnPE([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void ouWVbOQv2mbDKhok24h([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void kCZiYyQOCbs5t62nnTy([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object HLvvntQESxmsphaQhl9([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void rYNaGHQF6qPEaYSoX37([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object kbqdOoQx6IvVXA9VRIb()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void iw9D4wQuyMa7c9VQI8W([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object jMSAZ6QeaYQ5i32v7OT()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void gxg1sfQ068yOekaxgLM([In] int obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void dOENUyQGfLU4RxHc7E6([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object CcjmLsQqMaaRE8GB7GS([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static System.Type hJuRplQluWIZn4pysix([In] RuntimeTypeHandle obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object UjojsxQwCVkEBevLnHo([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void juoJnbQt5aeLCwVEcm6([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void gLcCwwQWsS9WuVVkSFU([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static RuntimeTypeHandle kSBc0LQkJqnJ7XgM5dL(int token)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object lraZ2hQ3Yc40cNN876k([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object OojefLQTB36h8K5wO6h([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int mDpda9QYHj65hud4Hr8([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object oMK8XFQSv42DQkPhAWA([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool UsUJR7QcZce5SXPZhfb([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool DIwCHVQ61IftdmwPGvq([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object XmC8MQQbYkeMen4KSxH([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void dVF2OyQ7nUXQHH5OcnE([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static PgADUw050obe94RDW7 DMKkblQK9BuSixZDxAp([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool Imka9XQpG8epjlrWUCi([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void bsoyUdQ2VxpPaMfATCm([In] object obj0, [In] int obj1, [In] bool obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void KAp72uQgEPZjm7jW0VZ([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void Mlyc3MQCmvYnZSs2Xev([In] object obj0, [In] DateTime obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool lShdpZQi3n4HK30bcXb([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object OOIZ1gQMBQ1hfwg4DO3([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object ovufxYQBFtKHoYgcIeC([In] Environment.SpecialFolder obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void TKA6uJQ55oVskM9CLZE([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool wk4UsmQVgvIwDH3Mp9g([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void xb12rcQDSlC5ocIt8Ug([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void CYaUB9QRq2LXgSpXRHJ([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Color Pj8tGLQNeLmBtdP5dpP()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object M0mDb6Qnc1yJS60HLHK([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object i6PVTPQhQaDN14fe8M6()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object nQAYkjQ8L1xeOFGUATI([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object BEaOD4QawVooK9KCsvn([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool QJRXTuQPpyrvh9UHmKn([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object bGIxZPQAcL1auX6Jh9W([In] object obj0, [In] object obj1, [In] object obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object kbHKaUQ1c4Uxn4lhbtp([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool aYFnX5Q4rsDTwF0gbIt([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void EMreehQjvFBeDq5ZRFZ([In] object obj0, [In] Color obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void DX8WwuQLL4TbB29DOxc([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object PpEaA7QmLRuWcrSYS6l([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object Ogqek9QHYHbjoPrTtIl([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object BituJZQXZ8RWEtUueIs([In] object obj0, [In] object obj1, [In] object obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void UpXI5qQJpSjB8NaTQhw(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void z9qnerQfDIiKRiDqBbR()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object lZB4AiQ9QFtIN4rcoF9([In] object obj0, [In] object obj1, [In] object obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Decimal G04VNoQzl6AvYHa14V5([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int XdKaPkUsJv590lpDMMK([In] Decimal obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object LKbjUjUyHR34FcsjQOC([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void njDHjLUdInfR2ffbRFx([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object Rg6uf6UI1ZXAIfALZLv([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object agrcoOUoS1iWvN0dh5n()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void XhZRi7UQqihhh3X9EnT([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void mI8l8CUU4dLppjgcaZo([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object LVN6BgUrM3ev0TtBUFB([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object HBoZ7BUZY5Py9PJeqg4([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object b36RAOUvdcjOhDKXf6q([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int oK84mSUOHoIVCVZ6Mar([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object nwwauVUETJou43oCn9B([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object fG1JPyUFQRb90PfS8Da()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DateTime S0h9CYUx1EHALOB0Bwr([In] object obj0, [In] object obj1, [In] object obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object U6Ed02UuGATYmo0PDf2([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void aqE8apUeAwHUBeAGimj()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object MdGqe4U04kdlmqPMxnt([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object hXP8tDUGSyFBCRV4bg3([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object CSJu2EUqohgO9eijQnc([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool VRvmFvUlvcV2myjxxPg([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object SQ2ZsUUwXlUmjP8A728([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object lRgixbUtMGlFZxS5j1x([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object A8f7MuUWmZVT40d8Cib([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object S3IndKUkQ5RYddKshbb([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int gfkrHnU3vupLduYrOqX([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object edXgZ6UT6fvmEIS6xTB([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object JM4ViIUYyOnxSsuqFE4([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object DUxWv9USkAYguQGHb9M([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int IH4c4oUcbAZZP1ddXn9([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object SmQ8k9U6AiYF5DilNS1([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object a7UXKCUbhxANvaT2DoF([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object Vx0RlwU7IZM24hQ8oB4([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object pbFGj0UKPOIA5xqJVfP([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object bhpRNOUpLlBD062LYYb([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object PDA4UJU2OboGYe9o1v1([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool aDnN1uUgDeyRcN7RWRO([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool wKhMROUCBZaXxUhRNrL([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object KUE2YgUiPUctpJN5ncT()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void K3c0wpUMviq4ZLg1oLi([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DateTime ykv38XUB6sUFPYVlOAE()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object CQhkk2U5AeXQ0ppycFG([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object iX6DtyUVsNyFP6aKeZp([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object TuHoSbUDo63QjmUlH5N([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object IcPUlWUR8WsjkYLIEXc([In] object obj0, [In] int obj1, [In] int obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object as7cN8UN09c9Sy0gekH([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object m1FhOgUnM75atk8wuWw([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object OlnSBFUhsxSUQQbOsRQ([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool sm5HBJU81mBuPSL4Yko([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object nq8ybyUaSfZRr0303GE([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object pam2R3UPut9VMuVHybP([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int qLnEkkUARXvD0k30vt8([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object axYwOKU13Q5luqtcyuA([In] object obj0, [In] int obj1, [In] int obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int qnFml2U4EIeCTe62U0k([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int y5s5PJUjCEefPlOVbM4([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object nHtBTBUL06WarXvSZa5([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int s535GGUmSOupYAGvi6n([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static float SwZDuNUH5JTAU1HYvmr([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Decimal iPhAl7UXNaGSh4tbX3v([In] Decimal obj0, [In] Decimal obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Decimal DKqr2yUJr553kP9v6nv([In] Decimal obj0, [In] Decimal obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static long PrDH2CUf0r7Ghy0vy3X([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void rF9EKbU98gRv6tj8wN8([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void C4RlU7UzgY0HrFpMZuU([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int dksNZvrsZaG8vj95lDC([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void dk0RCxry9LamLwr4YeQ([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void MsA65ZrdZx5GsNnfVoJ([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void bsN88irIcm2Oq7m3rrN([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int s98vM9rolox2sIALQi9([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object VPryyArQPRe2lJJ71AE([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object wUsxA1rUSLw25YpbRAP([In] object obj0, [In] object obj1, [In] int obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int PZqSw7rrgyZdl8P1QLG([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int NrDxkdrZtB4dgaXCfWf([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static double iVGvVkrvFsn9TrgNDTX([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object FLeG2TrOm40hq4fhLRE([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void XHbA9ArE4JqqSZWAa7K([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int c89LI0rFF9GG9w3Iuiw([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object qKXyjkrxaB97lYy67d9([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void AHbcopruv7qx9XoAsrj([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void PxB7lAreJ81xlGEuacD([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void MNWTw1r0Lo7SXeYOZE0([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void WvmCwJrGOEQ40g5WEEY([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object pfxM4mrqebAKfSIoq1N()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object lJ4aFxrlWWC7yE3EkQ2()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object n0iqDhrwLD4UdbwjpJ4()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object gaYdR5rtILktPrBToOp()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void oJCNpfrW0cp48HvEqyi([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object hbsVWqrk22JeodsWSPf()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool jhEnltr3yFUeZvqFIDg([In] TimeSpan obj0, [In] TimeSpan obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool S69jbjrTmIPM0ALmsAl([In] TimeSpan obj0, [In] TimeSpan obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static TimeSpan kEojwIrYhnmmGIujUYg([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DateTime LVDn3MrS8sNpiIZSFaO([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void XNof3BrcZrq2ML1FKl6([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void XN9IFYr60BqGvJohFdo([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool C7MIntrbs5lUNjCZ8hg([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int NU4qHur7RDCEIDFgbAo([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object TU0yoerK9etbUVtHAL9([In] object obj0, [In] char obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object BMHAqlrpWddY8gQajTt([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void zh9FRTr2H0T3GNuiYB6([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object jyqCsIrgf2L39TJH0bx([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int DYtrpXrCCFPhyi6m8QB([In] object obj0, [In] int obj1, [In] int obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DialogResult Lc6VcdriSdaW6bSWbVF([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void vXSuGBrMryG8moC4d3Y([In] object obj0, [In] Color obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Color QJCiirrBQbndOnXA5VD([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static IntPtr yXwtGQr5L3FAk8LNIW9([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static IntPtr uu1WvZrVhupgne6OmwP([In] int obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void dUHv55rDrhhLVKAbn5C([In] object obj0, [In] IntPtr obj1, [In] bool obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void eNspd6rRA51WiEBS73O([In] IntPtr obj0, [In] System.Type obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool jqYdjbrN6UA0QDMEOqC([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void VuLrgMrn4JhkQb1oKrD([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void vLlfCRrhik3sSM0E5oF([In] object obj0, [In] object obj1, [In] object obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object HvQVTgr8VITpbocBNh4([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool agcTeSraj3ds0DNXXBe([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void RpwvserPImqW2iJBBlo()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool v3S6HUrAlCBZCraB2cu([In] DateTime obj0, [In] DateTime obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object UfhZ8Gr1wybndMjg5fn([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static double aDNDP8r40o68YbgQXy4([In] double obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object eKSQ7lrjGYvIShsrVFA([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object dN46gHrL2PCln5t7ul4([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int zplEnkrmWrADCSRLBYv([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void yR4nCsrH7qykntIQWwi([In] object obj0, [In] object obj1, [In] object obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object gSZFUVrXJARUMN7nZUd([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object B4jeiJrJ979AX44dg2F([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object VJY2oGrfhDgOi4g5MeE([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Point Yuie2Wr9dCpIosgLwq4([In] object obj0, [In] Point obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Point HcdkA7rzWjuBjXMybnl([In] object obj0, [In] Point obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Point b8t75BZsl7NG6yDK3as([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void EKHXRcZy2ZY1pqnVhMC([In] Point obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void JCkOAfZd5pmMp2O52lI([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void goEZcaZITtQUGjTOFtY([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void gPRkVRZoiLqMgBX17yY([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object I3xYXpZQcp7ha5DuduG([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool AgDoRKZUBqRRI22KNHI([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void S86GgyZrpHL5UwfvyUW([In] object obj0, [In] object obj1, [In] object obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool sUun1MZZ7lIRWclm66i([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool dgSCaSZvD7xxqZlRn05([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void M78923ZOcPhvbraignj([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void hlGTjxZEFZLK89UPqv4([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object qiw5cTZF7cNEZvgZPXM([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void hpJMgHZx2d5ktmdac5l([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object pOgge5ZuAPnAXU3Y5yb([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DialogResult P9dNI7Ze05o3yU1kREn(
      [In] object obj0,
      [In] object obj1,
      [In] MessageBoxButtons obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object OqeZWCZ0ebGTNowKaCg([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object WjR4ruZGmyWyhtchmsj([In] object obj0, [In] FileMode obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static System.Type M6ZlGXZq8JKhnfrP1Yc([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void m9cYd0ZlTo7DapsVDrU([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int g0bHcuZwr6AcJXFQINn([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int PxYWoOZt7VbBiKJT1Dw([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DialogResult FwINGxZWw2rLerkVZs3(
      [In] object obj0,
      [In] object obj1,
      [In] MessageBoxButtons obj2,
      [In] MessageBoxIcon obj3,
      [In] MessageBoxDefaultButton obj4)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Color Nr3hufZkCvZvvivqAB9()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Color uqjvvCZ3MHT24td6Rde()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Color ttXq5WZTlVB0BGvQWgi()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Color CpLvMdZYqcvQXhrMUFd()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool FN8mi3ZS75RRRIvBHKF([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object t7HRZ3Zc64MGuAQFUsN()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void RsUiW6Z6MY9D4QRdrSE([In] object obj0, [In] object obj1, [In] object obj2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object xD8U7iZb1Ca1YGKN85Q([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void G1SJ2dZ7feu8NTH60Se([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void iXckasZKlYkXPFxBlxT([In] int obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void FBenuDZpmTjwON4QOWW()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool d03cZqZ2E6uemsbCndq([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Rectangle F0wcIeZgAOgPK61k3Sx([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void hvakcmZCFZEFgNJWgYP([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void yDNVyYZip2moXLM1HN7([In] object obj0, [In] object obj1, uint _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Color CU9YkpZMJSOXSoSjuA1()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DialogResult o3ArZcZBrvFIX3e3yxJ([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object ufEjjoZ5rWF9UFmc1V5([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object jZ01HMZVMSmouPLpJAS()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void y5ytDyZDxM9DNQnfPdU([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object e13b7xZR2C6I9ONOoMF([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object FW5JkjZNixybDrVWeQX([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void RcNkGqZnYWJsjRkPs7D([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void cAqxE4ZhThpe9Xo0Z02([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void LCZlNGZ86CF1OB6ltJO([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void GMFeADZa1CDXin9kdlc([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void zED0UFZPeNUBDhHfVQ5([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void dYVCCWZAt9tDw8dth2M([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void PJTJBtZ1yd0rIyJkU6a([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void hgQYgPZ4Yj2FU6pKqou([In] object obj0, [In] Size obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SQS1vWZjMRvov8aHphh([In] object obj0, [In] Point obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void TmDi7SZL96kqT3ktnRY([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Color IDfgOFZmSuHZNPua2OO()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void gZcfFbZHNu1GAIeLLpn([In] object obj0, [In] Point obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void eUeiriZXYbrWSOJH8y4([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void wcjvmcZJOkdTIp25mJv([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void krcQc6ZftxfXATGCrrc([In] object obj0, [In] Padding obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void pI68t3Z9AxnAO00W5XA([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void GDBbqBZzVDd2dYTTDH6([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void kxwHxVvsTAZly1d8Fh9([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void vFLRLRvyeomcdAw542x([In] object obj0, [In] ContentAlignment obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void c4EmTAvd5f2TdwRq5ml([In] object obj0, [In] AnchorStyles obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void xBiF78vIhoFR1CsfXQQ([In] object obj0, [In] ComboBoxStyle obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void T9Hv7uvo4GQgpy4gDWN([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void ShMiNHvQKWOgjGC80xu([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void i9n65xvUskImGtGd8wN([In] object obj0, [In] char obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void mdAmshvrNqXbiCGENYt([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void gbu7p0vZD8PBcdC4y6B([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int iarSj4vvw0TNnqpvsQu([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object Olk7nZvOIXvRymjkJBX([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void zOs2davES5sAxv91UqC([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int RxYtBivFWnH2W8vyKQg([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object tc62MHvxQ0GrPJwl77r([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void M1pp58vux6vSCX3UL3Q([In] object obj0, [In] DateTimePickerFormat obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void Kmb4xOveLjMpIlhVB0l([In] object obj0, [In] ContentAlignment obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void aRcQO9v0HIbvAHtWQB7([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void jyJ9OqvGDiJ3L39a3Hk([In] object obj0, [In] ContentAlignment obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void M5lvFZvqvQ8dEYfn9pn([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void IykyN4vlQBrioNgdOpn([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void aYPoKcvwVZ8uUkdJ24b([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void ciQf7EvtDrd8V9n3ceY([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void cisqmEvWb29Lv1WQyoE([In] object obj0, [In] Decimal obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void mSniaQvkTxN9KXLBCel([In] object obj0, [In] Decimal obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void Q6JmD9v3uDMsYTWMOaP([In] object obj0, [In] Decimal obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void TfxIOkvT5052DvRggIE([In] object obj0, [In] FlatStyle obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void w8DVdevYvr1lSEYQ4vB([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void zQArBVvSNN9YgSYxKFm([In] object obj0, [In] ImageLayout obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void dQNDb8vcFmqABpptldr([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void qmwduGv6lUwQ8vgxZnf([In] object obj0, [In] TableLayoutPanelCellBorderStyle obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void luaxravbYE4GiHWCkAF([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void p3Xw8Xv7V26mofCE3RA([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void gLHYsyvK0yJ2qV0tpnG([In] object obj0, [In] ScrollBars obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void NQIOftvpc6BFXNbeqDA([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void opOeyXv2tOt3OkNfSwT([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object bPIYuuvgcxaPHdc2cok()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object q46QYZvCdKDQNg5bFfQ()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void B4uv5yviuBUSkT7FPKo([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object YUSe35vMDAkmKyhMYQV([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void MmjHDLvBrGj1nqkb3RS([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void HROGiHv5Ons2t5exmEP([In] object obj0, [In] int obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void jLIjiovVVE4125lHG5D([In] object obj0, [In] Size obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void MTIVInvDJwffH3jdrO4([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void QNDF1CvRHH9r3x8sYTV([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void dNvWmavNWAgoJAgoyqF([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void yyVnN4vnaOWUvYJi6yZ([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void X6PHLKvh6OtFVGef1AK([In] object obj0, [In] Size obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void Raqumrv8rD6WY2FuWNM([In] object obj0, [In] Padding obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void MQT9o2vaoPqv9yOj0ri([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void DFserDvPFRN64yShIJT([In] object obj0, [In] object obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void u46poavAoUjke5Wiyt7([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void icgtfVv1vKoCgNBbQkH([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void c3VNu9v4kpsapcWxJnD([In] object obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void yurqkDvjLb3NmwR2FOI([In] object obj0, [In] bool obj1)
    {
      // ISSUE: unable to decompile the method.
    }

    private struct A9qSyp7TWVrBx9ibTo
    {
      public string PfIX2V6WOB;
      public string feCXT4eifk;
    }

    private delegate bool GEOhWnZiBFPiyfUlE7();

    private delegate void vxJFwXd3eVGe94oOBA(object sender, EventArgs e);

    internal struct sIAc91KU8cmcxURFKD : IComparable<ReBot.ReBot.sIAc91KU8cmcxURFKD>
    {
      public string RUWXNt32m6;
      public string egWXVsd075;
      public string kKXXt2y6GP;
      public string HRdXMspEor;
      public DateTime cSBXHejrsG;
      public int QccXvMqdN4;
      public int uHVXcSQwhm;
      public int PdSXjRp3Ja;
      public int ihGXybvPWp;
      public int TdAXSZ7m8D;
      public int x5XXOq6MSs;
      public int AHQXq0fevs;
      public int QPcXXBUsQI;
      public int xC8XDkLs4e;
      public int CxsXY2vkOg;
      public int YOnXFGlybs;
      public int M9FXe8nrAj;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int CompareTo(ReBot.ReBot.sIAc91KU8cmcxURFKD _param1)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int GGgXl8ODGl(
        ReBot.ReBot.sIAc91KU8cmcxURFKD _param0,
        ReBot.ReBot.sIAc91KU8cmcxURFKD _param1)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static int UdRqRyEJo9AkXOVkGwT([In] object obj0, [In] object obj1)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static bool cck07KEHP5vlWkekaLl()
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static bool RXU3XPEXWqZEsDKWWqM()
      {
        // ISSUE: unable to decompile the method.
      }
    }

    public struct PlayerInfo : IComparable<ReBot.ReBot.PlayerInfo>
    {
      public static SortOrder order;
      public int Number;
      public string Surname;
      public string ID;
      public bool NotAvailable;
      public string Position;
      public string Combination;
      public int Age;
      public int Skill;
      public int Hits;
      public int Power;
      public int Morale;
      public int Talent;
      public int Task;
      public string Pos;
      public int BuilderLine;
      public bool IsMainTeam;
      public bool IsReserve;
      public sbyte Prioritet;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int CompareTo(ReBot.ReBot.PlayerInfo other)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int ByNumberAll(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int ByPower(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int BySkill(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int ByHits(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int ByAge(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int ByMorale(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int ByTalent(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int ByNumber(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int ByRolesOrder(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int ByBuilderLine(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int ByPositionDesc(ReBot.ReBot.PlayerInfo player1, ReBot.ReBot.PlayerInfo player2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static bool Mq5MeOEfbt8H3RhUW39()
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static bool VDxw5fE9gyr4cP7GjaS()
      {
        // ISSUE: unable to decompile the method.
      }
    }

    public delegate void AddLogDelegate(string Action);

    internal struct NJdss92tpNUkgXBUqU
    {
      public int NDiXdW3cTi;
      public IntPtr yDgXmKhNeV;
      public IntPtr upNXPfBjWG;
    }

    public class Fixes
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void SetNotifyIconText(NotifyIcon ni, string text)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Fixes()
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static int vrabspFIGnQVDa5xBeQ([In] object obj0)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static object sr9sA8FoxCWPERSOlTg([In] object obj0, [In] int obj1, [In] int obj2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static RuntimeTypeHandle coUAkJFQU7X4reGvhfJ(int token)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static void MjO73kFUVvG8VLuX5EQ([In] object obj0, [In] object obj1, [In] object obj2)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static object B2XKrUFrAxi5bdYdAl1(int _param0)
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static bool sr7xFrFy0F7ir5U83hd()
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static bool dZmuxpFd5YZR2yD7joj()
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static void GhTpHUFZjRY8vqUQ2SC()
      {
        // ISSUE: unable to decompile the method.
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static void IlLtj3FvDN7bps5ThNy([In] object obj0)
      {
        // ISSUE: unable to decompile the method.
      }
    }

    private struct mNg0PB4XbocpT9U5ov
    {
      public long WqTX3ECb5P;
      public string HQKXxbMCjX;
    }

    private struct Yh2ZNv195dWJ5pHZZU
    {
      public CheckBox HvlXEYbH8S;
      public DateTimePicker kmyX0Vtal5;
      public DateTimePicker kbrXGvJguw;
      public CheckBox AWvXAV43e9;
      public CheckBox T1BXCE3Ff9;
      public CheckBox Ya5X4kaACm;
      public CheckBox wuxXnl5hfh;
      public CheckBox P7mXw2LcHL;
      public CheckBox WxPXugybA6;
      public CheckBox ABRXIxHX1v;
      public CheckBox tyaXBav8x0;
      public CheckBox Vq8XbiaKCx;
      public CheckBox qwoXWapjh6;
      public CheckBox QJYXgjEAfE;
      public ComboBox wJuXpDCxJD;
      public ComboBox L6sXab16Ap;
      public NumericUpDown dLOXhB3tFr;
    }

    private struct n1KFWaAX0X9XjDepdR
    {
      public CheckBox q0jXRoIX4E;
      public CheckBox FnFX61N9ST;
      public CheckBox kkDXUkl6On;
      public CheckBox llxXoqZALa;
    }

    private delegate void lNpINn5UBxtxRESBgu(bool status);

    public delegate R AsyncTask<R>();
  }
}
