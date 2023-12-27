using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeQuestData : MonoBehaviour
{
    private static bool _initializeData = false;
    private static QuestData _questData;
    public static QuestData QuestData { get { return _questData; } set { _questData = value; } }
    public static bool InitializeData { set { _initializeData = value; } }

    // Start is called before the first frame update
    private void Awake()
    {
        if (_initializeData == false)
        {
            InitializeBalanceExperienceQuestsDefaultValue();
            _initializeData = true;
        }
    }

    public static void InitializeBalanceExperienceQuestsDefaultValue()
    {
        _questData = new QuestData()
        {
            Quests = new Quest[] { new Quest() {Id = "start" , State = "doing", Type = "moving", Position = new Vector3(0.52f, 0.1f, 1.2f),Title = "Quest 1", Content = "E-Buoc tiep de bat dau"},
                    new Quest() {Id = "axe" , State = "lock", Type = "moving", Position = new Vector3(0.95f, 0.75f, 3.35f),Title = "Quest 1", Content = "E-Learning Axe Skill"},
                    new Quest() {Id = "sword" , State = "lock", Type = "moving", Position = new Vector3(1, 0.75f, 6.46f),Title = "Quest 1", Content = "E-Learning Sword Skill"},
                    new Quest() {Id = "shield" , State = "lock", Type = "moving", Position = new Vector3(1.28f, 0.75f, 9.21f),Title = "Quest 1", Content = "E-Learning Shield Skill"},
                   
                    new Quest() {Id = "001" , State = "lock", Type = "moving", Position = new Vector3(11, 0.74f, 24),Title = "Quest 1", Content = "E-Di den nga 3 dau tien"},
                    new Quest() {Id = "102" , State = "lock", Type = "attack", Position = new Vector3(11, 0.74f, 24), Progress = 0, Condition = 2 , Title = "Quest 2", Content = "E-Danh bai quai vat xuat hien"},
                    new Quest() {Id = "003" , State = "lock", Type = "moving", Position = new Vector3(37.7f, 0.93f, 18.0f), Title = "Quest 3", Content = "E-Di tiep ve ben phai"},
                    new Quest() {Id = "104" , State = "lock", Type = "attack", Position = new Vector3(37.7f, 0.93f, 18.0f), Progress = 0, Condition = 2, Title = "Quest 4", Content = "E-Danh bai quai vat 2 xuat hien"},
                    new Quest() {Id = "005" , State = "lock", Type = "moving", Position = new Vector3(11, 0.74f, 24) ,Title = "Quest 5", Content = "E-Di ve nga 3"},
                    new Quest() {Id = "006" , State = "lock", Type = "moving", Position = new Vector3(15, 4.4f, 68),Title = "Quest 5", Content = "E-Di thang den chan cau" },
                    new Quest() {Id = "007" , State = "lock", Type = "moving", Position = new Vector3(40, 9.84f, 77.42f),Title = "Quest 5", Content = "E-Den ben kia cau" },
                    new Quest() {Id = "008" , State = "lock", Type = "moving", Position = new Vector3(76, 0.5f, 97.34f),Title = "Quest 5", Content = "E-Di den bo song" },
                    new Quest() {Id = "109" , State = "lock", Type = "attack", Position = new Vector3(83.2f, 1.25f, 107f), Progress = 0, Condition = 4, Title = "Quest 4", Content = "E-Danh bai quai vat 3 xuat hien"},
                    new Quest() {Id = "010" , State = "lock", Type = "moving", Position = new Vector3(69, 0.55f, 156.5f),Title = "Quest 5", Content = "E-Di den hang dong" },
                    new Quest() {Id = "111" , State = "lock", Type = "attack", Position = new Vector3(63, 0.5f, 154), Progress = 0, Condition = 4, Title = "Quest 4", Content = "E-Danh bai quai vat 4 xuat hien"},
                    new Quest() {Id = "012" , State = "lock", Type = "moving", Position = new Vector3(98.27f, 2.24f, 173.51f),Title = "Quest 5", Content = "E-Di vao cong khong gian" },

                    new Quest() {Id = "axe" , State = "lock", Type = "moving", Position = new Vector3(0.95f, 0.13f, 3.35f),Title = "Quest 1", Content = "E-Learning New Axe Skill"},
                    new Quest() {Id = "sword" , State = "lock", Type = "moving", Position = new Vector3(1, 0.13f, 6.46f),Title = "Quest 1", Content = "E-Learning New Sword Skill"},
                    new Quest() {Id = "shield" , State = "lock", Type = "moving", Position = new Vector3(1.28f, 0.13f, 9.21f),Title = "Quest 1", Content = "E-Learning New Shield Skill"},

                    new Quest() {Id = "013" , State = "lock", Type = "moving", Position = new Vector3(0, -0.372f, 11),Title = "Quest 5", Content = "E-Di thang ve phia truoc" },
                    new Quest() {Id = "114" , State = "lock", Type = "attack", Position = new Vector3(0, -0.372f, 11), Progress = 0, Condition = 2, Title = "Quest 4", Content = "E-Danh bai quai vat 5 xuat hien"},
                    new Quest() {Id = "015" , State = "lock", Type = "moving", Position = new Vector3(1.17f, -0.372f, 30),Title = "Quest 5", Content = "E-Di thang tiep ve phia truoc" },
                    new Quest() {Id = "116" , State = "lock", Type = "attack", Position = new Vector3(1.17f, -0.372f, 30), Progress = 0, Condition = 1, Title = "Quest 4", Content = "E-Danh bai quai vat Boss 6 xuat hien"},
                    new Quest() {Id = "017" , State = "lock", Type = "moving", Position = new Vector3(-12, -0.372f, 25.5f),Title = "Quest 5", Content = "E-Di vao cong khong gian 2" },

                    new Quest() {Id = "axe" , State = "lock", Type = "moving", Position = new Vector3(0.95f, 0.31f, 3.35f),Title = "Quest 1", Content = "E-Learning New Axe Skill"},
                    new Quest() {Id = "sword" , State = "lock", Type = "moving", Position = new Vector3(1, 0.31f, 6.46f),Title = "Quest 1", Content = "E-Learning New Sword Skill"},
                    //new Quest() {Id = "shield" , State = "lock", Type = "moving", Position = new Vector3(1.28f, 0.75f, 9.21f),Title = "Quest 1", Content = "E-Learning New Shield Skill"},

                    new Quest() {Id = "018" , State = "lock", Type = "moving", Position = new Vector3(-8.3f, -0.08f, -2.36f),Title = "Quest 5", Content = "E-Di thang ve phia truoc" },
                    new Quest() {Id = "119" , State = "lock", Type = "attack", Position = new Vector3(-8.3f, -0.08f, -2.36f), Progress = 0, Condition = 1, Title = "Quest 4", Content = "E-Danh bai quai vat 7 xuat hien"},
                    new Quest() {Id = "020" , State = "lock", Type = "moving", Position = new Vector3(-47f, -0.08f, -10.5f),Title = "Quest 5", Content = "E-Tiep tuc di thang ve phia truoc" },
                    new Quest() {Id = "121" , State = "lock", Type = "attack", Position = new Vector3(-47f, -0.08f, -10.5f), Progress = 0, Condition = 2, Title = "Quest 4", Content = "E-Danh bai quai vat 8 xuat hien"},
                    new Quest() {Id = "022" , State = "lock", Type = "moving", Position = new Vector3(-24f, -0.08f, 30.6f),Title = "Quest 5", Content = "E-Di den cong da" },
                    new Quest() {Id = "123" , State = "lock", Type = "attack", Position = new Vector3(-24f, -0.08f, 30.6f), Progress = 0, Condition = 4, Title = "Quest 4", Content = "E-Danh bai quai vat 9 xuat hien"},
                    new Quest() {Id = "024" , State = "lock", Type = "moving", Position = new Vector3(36.7f, 8.35f, 61f),Title = "Quest 5", Content = "E-Qua cong da leo len ngon doi ben trai" },
                    new Quest() {Id = "125" , State = "lock", Type = "attack", Position = new Vector3(36.7f, 8.35f, 61f), Progress = 0, Condition = 3, Title = "Quest 4", Content = "E-Danh bai quai vat 10 xuat hien"},
                    new Quest() {Id = "026" , State = "lock", Type = "moving", Position = new Vector3(62.7f, 13.9f, 91.14f),Title = "Quest 5", Content = "E-Di den ngoi doi doi dien" },
                    new Quest() {Id = "127" , State = "lock", Type = "attack", Position = new Vector3(62.7f, 13.9f, 91.14f), Progress = 0, Condition = 3, Title = "Quest 4", Content = "E-Danh bai quai vat 11 xuat hien"},
                    new Quest() {Id = "028" , State = "lock", Type = "moving", Position = new Vector3(-9.84f, 40.63f, 104.68f),Title = "Quest 5", Content = "E-Di len ngon nui cao nhat" },
                    new Quest() {Id = "129" , State = "lock", Type = "attack", Position = new Vector3(-9.84f, 40.63f, 104.68f), Progress = 0, Condition = 4, Title = "Quest 4", Content = "E-Danh bai quai vat canh cong 12 xuat hien"},
                    new Quest() {Id = "030" , State = "lock", Type = "moving", Position = new Vector3(-17.9f, 40.56f, 89.5f),Title = "Quest 5", Content = "E-Di vao cong khong gian" },

                    new Quest() {Id = "031" , State = "lock", Type = "moving", Position = new Vector3(8, 0.38f, 9),Title = "Quest 5", Content = "E-Di thang ve phia truoc" },
                    new Quest() {Id = "132" , State = "lock", Type = "attack", Position = new Vector3(8, 0.38f, 9), Progress = 0, Condition = 5, Title = "Quest 4", Content = "E-Danh bai quai vat 13 xuat hien"},
                    new Quest() {Id = "033" , State = "lock", Type = "moving", Position = new Vector3(39, 6.82f, 8.5f),Title = "Quest 5", Content = "E-Leo len vung dat ben phai" },
                    new Quest() {Id = "134" , State = "lock", Type = "attack", Position = new Vector3(39, 6.82f, 8.5f), Progress = 0, Condition = 4, Title = "Quest 4", Content = "E-Danh bai quai vat 14 xuat hien"},
                    new Quest() {Id = "035" , State = "lock", Type = "moving", Position = new Vector3(85, 21.68f, 38),Title = "Quest 5", Content = "E-Bay len vung dat phia truoc" },
                    new Quest() {Id = "136" , State = "lock", Type = "attack", Position = new Vector3(85, 21.68f, 38), Progress = 0, Condition = 2, Title = "Quest 4", Content = "E-Danh bai quai vat 15 xuat hien"},
                    new Quest() {Id = "037" , State = "lock", Type = "moving", Position = new Vector3(65.4f, 50.88f, 68.5f),Title = "Quest 5", Content = "E-Di len vung dat cao nhat" },
                    new Quest() {Id = "138" , State = "lock", Type = "attack", Position = new Vector3(65.4f, 50.88f, 68.5f), Progress = 0, Condition = 3, Title = "Quest 4", Content = "E-Danh bai quai vat 16 xuat hien"},
                    new Quest() {Id = "039" , State = "lock", Type = "moving", Position = new Vector3(65.4f, 50.88f, 84),Title = "Quest 5", Content = "E-Di len vung dat cao nhat" },
                    new Quest() {Id = "140" , State = "lock", Type = "attack", Position = new Vector3(65.4f, 50.88f, 84), Progress = 0, Condition = 1, Title = "Quest 4", Content = "E-Danh bai quai vat 16 Boss xuat hien"},

                    new Quest() {Id = "complete" , State = "lock", Type = "moving", Position = new Vector3(111, 111, 111) ,Title = "Quest 5", Content = "Complete Quest"},

            }
        };
    }

    public static void InitializeChallengeQuestsDefaultValue()
    {
        _questData = new QuestData()
        {
            Quests = new Quest[] { new Quest() {Id = "start" , State = "doing", Type = "moving", Position = new Vector3(0.52f, 0.1f, 1.2f),Title = "Quest 1", Content = "C-Buoc tiep de bat dau"},
                    new Quest() {Id = "axe" , State = "lock", Type = "moving", Position = new Vector3(0.95f, 0.75f, 3.35f),Title = "Quest 1", Content = "C-Learning Axe Skill"},
                    new Quest() {Id = "sword" , State = "lock", Type = "moving", Position = new Vector3(1, 0.75f, 6.46f),Title = "Quest 1", Content = "C-Learning Sword Skill"},
                    new Quest() {Id = "shield" , State = "lock", Type = "moving", Position = new Vector3(1.28f, 0.75f, 9.21f),Title = "Quest 1", Content = "C-Learning Shield Skill"},

                    new Quest() {Id = "001" , State = "doing", Type = "moving", Position = new Vector3(11, 0.74f, 24),Title = "Quest 1", Content = "C-Di den nga 3 dau tien"},
                    new Quest() {Id = "202" , State = "lock", Type = "attack", Position = new Vector3(11, 0.74f, 24), Progress = 0, Condition = 3 , Title = "Quest 2", Content = "C-Danh bai quai vat xuat hien"},
                    new Quest() {Id = "003" , State = "lock", Type = "moving", Position = new Vector3(37.7f, 0.93f, 18.0f), Title = "Quest 3", Content = "C-Di tiep ve ben phai"},
                    new Quest() {Id = "204" , State = "lock", Type = "attack", Position = new Vector3(37.7f, 0.93f, 18.0f), Progress = 0, Condition = 3, Title = "Quest 4", Content = "C-Danh bai quai vat 2 xuat hien"},
                    new Quest() {Id = "005" , State = "lock", Type = "moving", Position = new Vector3(11, 0.74f, 24) ,Title = "Quest 5", Content = "C-Di ve nga 3"},
                    new Quest() {Id = "006" , State = "lock", Type = "moving", Position = new Vector3(15, 4.4f, 68),Title = "Quest 5", Content = "C-Di thang den chan cau" },
                    new Quest() {Id = "007" , State = "lock", Type = "moving", Position = new Vector3(40, 9.84f, 77.42f),Title = "Quest 5", Content = "C-Den ben kia cau" },
                    new Quest() {Id = "008" , State = "lock", Type = "moving", Position = new Vector3(76, 0.5f, 97.34f),Title = "Quest 5", Content = "C-Di den bo song" },
                    new Quest() {Id = "209" , State = "lock", Type = "attack", Position = new Vector3(83.2f, 1.25f, 107f), Progress = 0, Condition = 5, Title = "Quest 4", Content = "C-Danh bai quai vat 3 xuat hien"},
                    new Quest() {Id = "010" , State = "lock", Type = "moving", Position = new Vector3(69, 0.55f, 156.5f),Title = "Quest 5", Content = "C-Di den hang dong" },
                    new Quest() {Id = "211" , State = "lock", Type = "attack", Position = new Vector3(63, 0.5f, 154), Progress = 0, Condition = 5, Title = "Quest 4", Content = "C-Danh bai quai vat 4 xuat hien"},
                    new Quest() {Id = "012" , State = "lock", Type = "moving", Position = new Vector3(98.27f, 2.24f, 173.51f),Title = "Quest 5", Content = "C-Di vao cong khong gian" },

                    new Quest() {Id = "axe" , State = "lock", Type = "moving", Position = new Vector3(0.95f, 0.13f, 3.35f),Title = "Quest 1", Content = "E-Learning New Axe Skill"},
                    new Quest() {Id = "sword" , State = "lock", Type = "moving", Position = new Vector3(1, 0.13f, 6.46f),Title = "Quest 1", Content = "E-Learning New Sword Skill"},
                    new Quest() {Id = "shield" , State = "lock", Type = "moving", Position = new Vector3(1.28f, 0.13f, 9.21f),Title = "Quest 1", Content = "E-Learning New Shield Skill"},

                    new Quest() {Id = "013" , State = "lock", Type = "moving", Position = new Vector3(0, -0.372f, 11),Title = "Quest 5", Content = "C-Di thang ve phia truoc" },
                    new Quest() {Id = "214" , State = "lock", Type = "attack", Position = new Vector3(0, -0.372f, 11), Progress = 0, Condition = 3, Title = "Quest 4", Content = "C-Danh bai quai vat 5 xuat hien"},
                    new Quest() {Id = "015" , State = "lock", Type = "moving", Position = new Vector3(1.17f, -0.372f, 30),Title = "Quest 5", Content = "C-Di thang tiep ve phia truoc" },
                    new Quest() {Id = "216" , State = "lock", Type = "attack", Position = new Vector3(1.17f, -0.372f, 30), Progress = 0, Condition = 3, Title = "Quest 4", Content = "C-Danh bai quai vat Boss 6 xuat hien"},
                    new Quest() {Id = "017" , State = "lock", Type = "moving", Position = new Vector3(-12, -0.372f, 25.5f),Title = "Quest 5", Content = "C-Di vao cong khong gian 2" },

                    new Quest() {Id = "axe" , State = "lock", Type = "moving", Position = new Vector3(0.95f, 0.31f, 3.35f),Title = "Quest 1", Content = "E-Learning New Axe Skill"},
                    new Quest() {Id = "sword" , State = "lock", Type = "moving", Position = new Vector3(1, 0.31f, 6.46f),Title = "Quest 1", Content = "E-Learning New Sword Skill"},
                    //new Quest() {Id = "shield" , State = "lock", Type = "moving", Position = new Vector3(1.28f, 0.95f, 9.21f),Title = "Quest 1", Content = "E-Learning New Shield Skill"},

                    new Quest() {Id = "018" , State = "lock", Type = "moving", Position = new Vector3(-8.3f, -0.08f, -2.36f),Title = "Quest 5", Content = "C-Di thang ve phia truoc" },
                    new Quest() {Id = "219" , State = "lock", Type = "attack", Position = new Vector3(-8.3f, -0.08f, -2.36f), Progress = 0, Condition = 2, Title = "Quest 4", Content = "C-Danh bai quai vat 7 xuat hien"},
                    new Quest() {Id = "020" , State = "lock", Type = "moving", Position = new Vector3(-47f, -0.08f, -10.5f),Title = "Quest 5", Content = "C-Tiep tuc di thang ve phia truoc" },
                    new Quest() {Id = "221" , State = "lock", Type = "attack", Position = new Vector3(-47f, -0.08f, -10.5f), Progress = 0, Condition = 3, Title = "Quest 4", Content = "C-Danh bai quai vat 8 xuat hien"},
                    new Quest() {Id = "022" , State = "lock", Type = "moving", Position = new Vector3(-24f, -0.08f, 30.6f),Title = "Quest 5", Content = "C-Di den cong da" },
                    new Quest() {Id = "223" , State = "lock", Type = "attack", Position = new Vector3(-24f, -0.08f, 30.6f), Progress = 0, Condition = 4, Title = "Quest 4", Content = "C-Danh bai quai vat 9 xuat hien"},
                    new Quest() {Id = "024" , State = "lock", Type = "moving", Position = new Vector3(36.7f, 8.35f, 61f),Title = "Quest 5", Content = "C-Qua cong da leo len ngon doi ben trai" },
                    new Quest() {Id = "225" , State = "lock", Type = "attack", Position = new Vector3(36.7f, 8.35f, 61f), Progress = 0, Condition = 3, Title = "Quest 4", Content = "C-Danh bai quai vat 10 xuat hien"},
                    new Quest() {Id = "026" , State = "lock", Type = "moving", Position = new Vector3(62.7f, 13.9f, 91.14f),Title = "Quest 5", Content = "C-Di den ngoi doi doi dien" },
                    new Quest() {Id = "227" , State = "lock", Type = "attack", Position = new Vector3(62.7f, 13.9f, 91.14f), Progress = 0, Condition = 3, Title = "Quest 4", Content = "C-Danh bai quai vat 11 xuat hien"},
                    new Quest() {Id = "028" , State = "lock", Type = "moving", Position = new Vector3(-9.84f, 40.63f, 104.68f),Title = "Quest 5", Content = "C-Di len ngon nui cao nhat" },
                    new Quest() {Id = "229" , State = "lock", Type = "attack", Position = new Vector3(-9.84f, 40.63f, 104.68f), Progress = 0, Condition = 5, Title = "Quest 4", Content = "C-Danh bai quai vat canh cong 12 xuat hien"},
                    new Quest() {Id = "030" , State = "lock", Type = "moving", Position = new Vector3(-17.9f, 40.56f, 89.5f),Title = "Quest 5", Content = "C-Di vao cong khong gian" },

                    new Quest() {Id = "031" , State = "lock", Type = "moving", Position = new Vector3(8, 0.38f, 9),Title = "Quest 5", Content = "E-Di thang ve phia truoc" },
                    new Quest() {Id = "232" , State = "lock", Type = "attack", Position = new Vector3(8, 0.38f, 9), Progress = 0, Condition = 5, Title = "Quest 4", Content = "E-Danh bai quai vat 13 xuat hien"},
                    new Quest() {Id = "033" , State = "lock", Type = "moving", Position = new Vector3(39, 6.82f, 8.5f),Title = "Quest 5", Content = "E-Leo len vung dat ben phai" },
                    new Quest() {Id = "234" , State = "lock", Type = "attack", Position = new Vector3(39, 6.82f, 8.5f), Progress = 0, Condition = 4, Title = "Quest 4", Content = "E-Danh bai quai vat 14 xuat hien"},
                    new Quest() {Id = "035" , State = "lock", Type = "moving", Position = new Vector3(85, 21.68f, 38),Title = "Quest 5", Content = "E-Bay len vung dat phia truoc" },
                    new Quest() {Id = "236" , State = "lock", Type = "attack", Position = new Vector3(85, 21.68f, 38), Progress = 0, Condition = 4, Title = "Quest 4", Content = "E-Danh bai quai vat 15 xuat hien"},
                    new Quest() {Id = "037" , State = "lock", Type = "moving", Position = new Vector3(65.4f, 50.88f, 68.5f),Title = "Quest 5", Content = "E-Di len vung dat cao nhat" },
                    new Quest() {Id = "238" , State = "lock", Type = "attack", Position = new Vector3(65.4f, 50.88f, 68.5f), Progress = 0, Condition = 4, Title = "Quest 4", Content = "E-Danh bai quai vat 16 xuat hien"},
                    new Quest() {Id = "039" , State = "lock", Type = "moving", Position = new Vector3(65.4f, 50.88f, 84),Title = "Quest 5", Content = "E-Di len vung dat cao nhat" },
                    new Quest() {Id = "240" , State = "lock", Type = "attack", Position = new Vector3(65.4f, 50.88f, 84), Progress = 0, Condition = 3, Title = "Quest 4", Content = "E-Danh bai quai vat 16 Boss xuat hien"},

                    new Quest() {Id = "complete" , State = "lock", Type = "moving", Position = new Vector3(111, 111, 111) ,Title = "Quest 5", Content = "Complete Quest"},

            }
        };
    }

    public static Quest GetCurrentQuest()
    {
        foreach(Quest quest in _questData.Quests)
        {
            if (quest.State == "doing")
            {
                return quest;
            }
        }
        return null;
    }

    public static void CompleteQuest()
    {
        for (int i = 0; i < _questData.Quests.Length; i++)
        {
            if (_questData.Quests[i].State == "doing")
            {
                _questData.Quests[i].State = "complete";
                if (_questData.Quests[i+1] != null)
                {
                    _questData.Quests[i + 1].State = "doing";
                }
                break;
            }
        }
    }

    public static void ProgressQuest()
    {
        Quest currentQuest = GetCurrentQuest();
        if ((currentQuest.Progress+1) == currentQuest.Condition)
        {
            CompleteQuest();
        } else
        {
            currentQuest.Progress += 1;
        }
    }

    public static QuestData GetQuestData()
    {
        return _questData;
    }

    public static void LoadQuestData(QuestData questData)
    {
        _questData = questData;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
