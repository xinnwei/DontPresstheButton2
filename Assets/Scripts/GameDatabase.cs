using UnityEngine;

// 所有静态设计数据集中管理，与运行时 GameData 分离
public static class GameDatabase
{
    // ============================================================
    // 区域信息
    // ============================================================
    public static readonly string[] areaNames =
    {
        "第一章：告别故土",
        "第二章：静默之地",
        "第三章：机械坟场",
        "第四章：泪之沼泽",
        "第五章：希望之城外"
    };

    // ============================================================
    // 10天收集事件（每天 +1~+3 零件，合计+17）
    // ============================================================
    public static readonly CollectionEventData[] collectionEvents =
    {
        new CollectionEventData { dayIndex=1,  partsGained=1,  description="路边散落着一些还能用的螺丝和垫片。" },
        new CollectionEventData { dayIndex=2,  partsGained=1,  description="废弃加油站的水箱里，找到了一个完好的过滤器。" },
        new CollectionEventData { dayIndex=3,  partsGained=2,  description="一辆翻倒的卡车旁，有两箱未拆封的零件。" },
        new CollectionEventData { dayIndex=4,  partsGained=1,  description="灌木丛里卡着一截金属管，大小刚好合适。" },
        new CollectionEventData { dayIndex=5,  partsGained=2,  description="路边的工作台上，散落着几件精密工具。" },
        new CollectionEventData { dayIndex=6,  partsGained=2,  description="废弃修车铺的角落里，发现了两个完好的齿轮。" },
        new CollectionEventData { dayIndex=7,  partsGained=2,  description="河道干涸的地方，露出了一捆电缆和几个接头。" },
        new CollectionEventData { dayIndex=8,  partsGained=1,  description="碎石堆下面，埋着一盒崭新的火花塞。" },
        new CollectionEventData { dayIndex=9,  partsGained=3,  description="一座废弃工厂的仓库里，居然还有整箱的备用零件。" },
        new CollectionEventData { dayIndex=10, partsGained=2,  description="靠近希望之城，路边多了些被遗弃的补给品。" },
    };

    // ============================================================
    // 5个区域的出行文本
    // ============================================================
    public static readonly string[][] travelDialogues =
    {
        new string[] {
            "破旧的甲壳虫驶离了熟悉的街道。",
            "母亲的八音盒放在副驾驶座上，安静地待着。",
            "她说过，永远别逆转它。",
            "前方的路，没有人知道通向哪里。"
        },
        new string[] {
            "荒野一片寂静，连风声都消失了。",
            "收音机只有沙沙的杂音。",
            "不知道是信号太弱，还是已经没有人在广播了。"
        },
        new string[] {
            "到处是锈迹斑斑的废弃机械。",
            "这里曾经是什么地方?",
            "也许能找到一些有用的零件。"
        },
        new string[] {
            "地面开始变得泥泞，车轮陷进去又挣脱出来。",
            "空气里有一股潮湿的气息。",
            "希望之城还有多远?"
        },
        new string[] {
            "远处的地平线上，隐约有建筑的轮廓。",
            "快到了。",
            "母亲说那里没有被影响，不知道是不是真的。"
        }
    };

    // ============================================================
    // 10个危机事件（按天顺序）
    // ============================================================
    public static readonly CrisisData[] crises =
    {
        // 区域1·告别故土
        new CrisisData {
            label = "1-1", area = 1,
            description = "前方的桥梁坍塌了半边，要绕过去得费不少力气。",
            optionA = new CrisisOption { label = "绕行桥下", willCost=2, partsCost=1, carHPCost=4,  log="从干涸的河床绕过了断桥，有惊无险。" },
            optionB = new CrisisOption { label = "冒险通过", willCost=3, partsCost=0, carHPCost=8,  log="硬着头皮开过去，车身刮得全是划痕。" },
            reversalSelfCost = 7
        },
        new CrisisData {
            label = "1-2", area = 1,
            description = "一群野狗挡住了去路，它们的眼睛在黑暗中泛着光。",
            optionA = new CrisisOption { label = "驱赶野狗", willCost=3, partsCost=1, carHPCost=6,  log="鸣笛驱散了野狗群，消耗了一些意志。" },
            optionB = new CrisisOption { label = "绕路躲避", willCost=2, partsCost=3, carHPCost=10, log="绕了很远的路，消耗了一些零件。" },
            reversalSelfCost = 8
        },

        // 区域2·静默之地
        new CrisisData {
            label = "2-1", area = 2,
            description = "浓雾吞没了道路，能见度不到三米。",
            optionA = new CrisisOption { label = "缓慢前行", willCost=4, partsCost=0, carHPCost=8,  log="一寸一寸挪出浓雾，神经绷到了极点。" },
            optionB = new CrisisOption { label = "靠零件探路", willCost=2, partsCost=3, carHPCost=14, log="自制了几个反光标记，总算找到了方向。" },
            reversalSelfCost = 9
        },
        new CrisisData {
            label = "2-2", area = 2,
            description = "车轮陷入了松软的沙地，越陷越深。",
            optionA = new CrisisOption { label = "垫东西脱困", willCost=3, partsCost=2, carHPCost=5,  log="用工具垫在轮下，挣扎着脱困了。" },
            optionB = new CrisisOption { label = "猛踩油门", willCost=5, partsCost=0, carHPCost=12,  log="一脚油门轰了出去，引擎冒出了黑烟。" },
            reversalSelfCost = 9
        },

        // 区域3·机械坟场
        new CrisisData {
            label = "3-1", area = 3,
            description = "堆积的废铁挡住了通道，需要清理出一条路。",
            optionA = new CrisisOption { label = "手动清障", willCost=4, partsCost=2, carHPCost=7,  log="徒手搬开了几块大铁片，筋疲力尽。" },
            optionB = new CrisisOption { label = "冲撞开路", willCost=3, partsCost=4, carHPCost=12,  log="加厚了保险杠直接撞过去，车头凹了一大块。" },
            reversalSelfCost = 10
        },
        new CrisisData {
            label = "3-2", area = 3,
            description = "引擎开始剧烈抖动，随时可能熄火。",
            optionA = new CrisisOption { label = "抢修引擎", willCost=5, partsCost=1, carHPCost=8,  log="临时抢修了一番，勉强稳住了引擎。" },
            optionB = new CrisisOption { label = "强撑前行", willCost=3, partsCost=5, carHPCost=14,  log="换了好几个零件撑着，总算没在半路抛锚。" },
            reversalSelfCost = 10
        },

        // 区域4·泪之沼泽
        new CrisisData {
            label = "4-1", area = 4,
            description = "暴雨倾盆，积水淹没了路面，看不清深浅。",
            optionA = new CrisisOption { label = "涉水慢行", willCost=5, partsCost=3, carHPCost=10, log="挂着一档慢慢趟过去，水没过了半个车轮。" },
            optionB = new CrisisOption { label = "等待雨停", willCost=4, partsCost=0, carHPCost=16, log="等了整整一天，雨水腐蚀了不少零件。" },
            reversalSelfCost = 11
        },
        new CrisisData {
            label = "4-2", area = 4,
            description = "泥沼中伸出一截扭曲的金属，划破了底盘。",
            optionA = new CrisisOption { label = "紧急修补", willCost=6, partsCost=1, carHPCost=8,  log="钻到车底修补，满身泥浆，总算堵住了破口。" },
            optionB = new CrisisOption { label = "强行离开", willCost=4, partsCost=3, carHPCost=14,  log="不顾渗漏加速离开，零件损耗严重。" },
            reversalSelfCost = 11
        },

        // 区域5·希望之城外
        new CrisisData {
            label = "5-1", area = 5,
            description = "前方道路被巨石封堵，绕路会消耗大量时间和零件。",
            optionA = new CrisisOption { label = "绕路而行", willCost=5, partsCost=4, carHPCost=12, log="绕了很远的路，消耗了大量零件。" },
            optionB = new CrisisOption { label = "尝试翻越", willCost=6, partsCost=1, carHPCost=8,  log="爬上了碎石坡，意志在绝望中变得坚定。" },
            reversalSelfCost = 12
        },
        new CrisisData {
            label = "5-2", area = 5,
            description = "一群饥肠辘辘的流浪者盯上了你的车，看样子不打算让路。",
            optionA = new CrisisOption { label = "谈判交涉", willCost=6, partsCost=4, carHPCost=15, log="用零件换了通行权，他们勉强同意了。" },
            optionB = new CrisisOption { label = "加速冲过", willCost=5, partsCost=0, carHPCost=20, log="一脚油门冲了过去，车几乎要散架。" },
            reversalSelfCost = 13
        },
    };

    // ============================================================
    // 8个结局（判断顺序从高到低）
    // ============================================================
    public static readonly EndingData[] endings =
    {
        new EndingData { id=1, title="奇怪的吟游诗人", minSelf=85, minCarHP=80,
            desc="你带着完整的自己抵达了希望之城。母亲的八音盒还在轻轻转动，你记得每一段旋律。" },
        new EndingData { id=2, title="坚定的前行者", minSelf=72, minCarHP=65,
            desc="一路的艰辛让你变了一些，但你知道自己是谁。你在城市边缘停下了车，久久望着灯火。" },
        new EndingData { id=3, title="蹒跚的幸存者", minSelf=58, minCarHP=48,
            desc="车几乎散架，你也差不多。但希望之城就在眼前。你活着，这就够了。" },
        new EndingData { id=4, title="褪色的旅人", minSelf=43, minCarHP=33,
            desc="你到了。有些记忆模糊了，有些名字想不起来了。但这旅途，总归是走到了终点。" },
        new EndingData { id=5, title="残响的过客", minSelf=28, minCarHP=18,
            desc="八音盒转了很多次。你站在城门口，却想不起自己为什么要来这里。" },
        new EndingData { id=6, title="空壳的回响", minSelf=12, minCarHP=1,
            desc="抵达希望之城的那一刻，你已经想不起自己的名字。这座城是别人的希望，不是你的。" },
        new EndingData { id=7, title="遗失之影", minSelf=1, minCarHP=0,
            desc="汽车彻底报废在了荒原上。你站在路边，看着地平线上那遥不可及的灯火。" },
        new EndingData { id=8, title="静默之人", minSelf=0, minCarHP=-1,
            desc="你不再记得自己是谁，也不再记得要去哪里。八音盒停下了，世界归于寂静。" },
    };

    // ============================================================
    // 自我完整度阶段效果
    // ============================================================
    public static readonly SelfIntegrityTierData[] selfIntegrityTiers =
    {
        new SelfIntegrityTierData { minValue=85, displayName="完整",     diaryGarbledRatio=0f,    bgmVolume=1f,   bgmDistortion=0f,   saturation=0f },
        new SelfIntegrityTierData { minValue=70, displayName="模糊",     diaryGarbledRatio=0.18f,  bgmVolume=1f,   bgmDistortion=0f,   saturation=0f },
        new SelfIntegrityTierData { minValue=55, displayName="旅人",     diaryGarbledRatio=0.50f,  bgmVolume=1f,   bgmDistortion=0f,   saturation=0f },
        new SelfIntegrityTierData { minValue=35, displayName="旅人",     diaryGarbledRatio=0.75f,  bgmVolume=0.8f, bgmDistortion=0.5f, saturation=0f },
        new SelfIntegrityTierData { minValue=15, displayName="旅人",     diaryGarbledRatio=0.90f,  bgmVolume=0.6f, bgmDistortion=0.75f,saturation=-60f },
        new SelfIntegrityTierData { minValue=1,  displayName="旅人",     diaryGarbledRatio=0.97f,  bgmVolume=0.2f, bgmDistortion=0.95f,saturation=-90f },
        new SelfIntegrityTierData { minValue=0,  displayName="......",   diaryGarbledRatio=1f,     bgmVolume=0f,   bgmDistortion=0f,   saturation=-100f },
    };

    // ============================================================
    // 查找方法
    // ============================================================
    public static CrisisData GetCrisis(int dayIndex)
    {
        int i = Mathf.Clamp(dayIndex, 0, crises.Length - 1);
        return crises[i];
    }

    public static CollectionEventData GetCollectionEvent(int dayIndex)
    {
        int i = Mathf.Clamp(dayIndex, 0, collectionEvents.Length - 1);
        return collectionEvents[i];
    }

    public static EndingData GetEnding(int selfIntegrity, int carHP)
    {
        if (selfIntegrity <= 0)
            return endings[7]; // 静默之人
        if (carHP <= 0)
            return endings[6]; // 遗失之影
        foreach (var e in endings)
        {
            if (selfIntegrity >= e.minSelf && carHP >= e.minCarHP)
                return e;
        }
        return endings[7]; // 兜底
    }

    public static SelfIntegrityTierData GetSelfIntegrityTier(int selfIntegrity)
    {
        foreach (var tier in selfIntegrityTiers)
        {
            if (selfIntegrity >= tier.minValue)
                return tier;
        }
        return selfIntegrityTiers[selfIntegrityTiers.Length - 1];
    }

    public static string GetTravelDialogue(int areaIndex, int lineIndex)
    {
        int a = Mathf.Clamp(areaIndex, 0, travelDialogues.Length - 1);
        var lines = travelDialogues[a];
        if (lineIndex < lines.Length)
            return lines[lineIndex];
        return null;
    }

    public static int GetTravelLineCount(int areaIndex)
    {
        int a = Mathf.Clamp(areaIndex, 0, travelDialogues.Length - 1);
        return travelDialogues[a].Length;
    }
}

// ============================================================
// 数据结构定义
// ============================================================

[System.Serializable]
public struct CollectionEventData
{
    public int dayIndex;
    public int partsGained;
    public string description;
}

[System.Serializable]
public struct CrisisOption
{
    public string label;
    public int willCost;
    public int partsCost;
    public int carHPCost;
    public string log;
}

[System.Serializable]
public struct CrisisData
{
    public string label;
    public int area;
    public string description;
    public CrisisOption optionA;
    public CrisisOption optionB;
    public int  reversalSelfCost;
}

[System.Serializable]
public struct EndingData
{
    public int id;
    public string title;
    public int minSelf;
    public int minCarHP;
    public string desc;
}

[System.Serializable]
public struct SelfIntegrityTierData
{
    public int minValue;
    public string displayName;
    public float diaryGarbledRatio;
    public float bgmVolume;
    public float bgmDistortion;
    public float saturation; // URP ColorAdjustments saturation (-100~0)
}
