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
