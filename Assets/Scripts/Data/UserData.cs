using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserData : SavePlayerPrefs
{
    public bool hasATM;
    public bool firstTimeWithDraw;
    public string lastTimePlayGame = string.Empty;
    public int incomePerMin;
    public int playerCash;
    public int playerDiamond;
    public int currentMap;
    public bool hasUnlockMap;
    public bool soundOn;
    public bool musicOn;
    public bool vibrateOn;
    public bool removeAds;
    public bool greatdeal;
    public bool premiumPackBought;
    public bool hasUseFreeTrial;
    public bool isResetQuest;
    public TutorialsData tutorials;
    public bool firstOpenApp;//flagAppOpenADS
    public bool firstOpenAppShop;//flag show premiumpack
    public bool firstLoading;//flagFirstLoading
    public bool firstMoveCamOnOpenApp;
    public bool isOpenTutorailToilet;
    public bool isOpenTutorailThermometer;
    public List<MapData> listMap;
    public DataTrackingFirebase dataTrackingFirebase;

    public int countDiamondDaily = 5;

    public bool isX2MoneyIap;
    public float timeX2Iap;
    public int countResetX2Money;


    public bool isCollectCashIap;
    public float timeCollectCash;
    public int countResetCollectCash;

    public bool isVehiIap;
    public float timeVehi;


    public bool isFirstClaimDailyReward;
    public bool isShowDailyReward;
    public DailyBonus dailyBonus = new();

    public UserData()
    {
        soundOn = musicOn = vibrateOn = true;
        listMap = new List<MapData>();
    }
    public MapData mapData
    {
        get => listMap[currentMap - 1];
    }

    public int MapExp
    {
        get => listMap[currentMap - 1].mapExp;
        set => listMap[currentMap - 1].mapExp = value;
    }

    public int MapLevel
    {
        get => listMap[currentMap - 1].mapLevel;
        set => listMap[currentMap - 1].mapLevel = value;
    }

    
}

[Serializable]

public class DailyBonus
{
    public string dateTracking = DateTime.Now.ToString();
    public int currentIndex = -1;
}



[Serializable]
public class MapData
{
    public int roomBaseID;
    public int idMap;
    public int mapExp;
    public int mapLevel;
    public int levelLoader;
    public int levelStaffCanteen;
    public int levelStaffCanteen2;
    public int levelReception;
    public List<bool> dataSkinReceptions=new();
    public int moneyUpgradeLoader;
    public int moneyUpgradeStaffCanteen;
    public int moneyUpgradeReception;
    public int moneyUpgradeZone;
    public List<ZoneData> listZone;
    public float timeIncrementalProgressGame;

    public MapData(int id)
    {
        idMap = id;
        mapLevel = 1;
        moneyUpgradeLoader = 0;
        moneyUpgradeStaffCanteen = 0;
        moneyUpgradeReception = 0;
        listZone = new List<ZoneData>();
    }

    public int GetZoneID()
    {
        return listZone[listZone.Count - 1].idZone;
    }
}

[Serializable]
public class ZoneData
{
    public int idZone;
    public List<RoomData> listRoom;

    public ZoneData(int id)
    {
        idZone = id;
        listRoom = new List<RoomData>();
    }
}

[Serializable]
public class RoomData
{
    public int location;
    public int level;
    public int currentUpradecash;
    public int indexTheme;
    public List<KiotData> kiots;

    public RoomData(int location, int level, int indexTheme)
    {
        this.level = level;
        this.location = location;
        kiots = new List<KiotData>();
        this.indexTheme = indexTheme;
    }
}

[Serializable]
public class KiotData
{
    public int toolRemain;
    public bool hasDoctor;
    public bool isTypeDoctorVip;
    public int doctorMana=10;

    public KiotData(int tool, bool doctor, int mana=10)
    {
        toolRemain = tool;
        hasDoctor = doctor;
        doctorMana = mana;
    }
}

[Serializable]
public class TutorialsData
{
    public bool script2;
    public bool script3;
    public bool script4;
    public bool script5;
    public bool script6;
    public bool script8WakeUpDoctor;
    public bool script9;//het thuoc
    public bool script10;//het thuoc2
    public bool script11;//lay giay vs
    public bool script12;
    //public bool script12b;
    public bool script13;
    public bool script14;//anh da den be hom
    public bool script15;//atm
    public List<int> CompletedTutoS = new();
    public bool tutorialDropMoney;
    public bool hasCreateMoneyItemAtPlayerPos = false;
    public bool hasCreateSpeedItemAtPlayerPos = false;
    public bool hasFreeSpeedItem = false;
    //WareHouse show item
    public bool hasShowItemMedince;
    public bool hasShowItemToiletPaper;
    public bool hasShowItemThermometer;

    public bool hasActiceArrow;

   
}

[Serializable]
public class DataTrackingFirebase
{
    public string timeStartReward = string.Empty;
    public string timeStartIntern = string.Empty;
    public string timeStartAppOpen = string.Empty;
    public string timeCanShowOpenADS = DateTime.Now.ToString();
    public List<int> trackingTimeIncrementalProgressGame = new();

    public int currentDataMapIndex = 0;
    public List<DataSession> dataMaps =
    new List<DataSession> { new DataSession(), new DataSession(), new DataSession(), new DataSession(), new DataSession(), new DataSession() };

   public int currentDataSession = 0;
    public List<DataSession> dataSessionS =
   new List<DataSession> { new DataSession(), new DataSession(), new DataSession(), new DataSession(), new DataSession()};


   
}

[Serializable]
public class DataSession
{
    public float minutes;
    public bool completed;
    public bool status;

    public DataSession(float minutes=0, bool completed=false, bool status=false)
    {
        this.minutes = minutes;
        this.completed = completed;
        this.status = status;
    }
}