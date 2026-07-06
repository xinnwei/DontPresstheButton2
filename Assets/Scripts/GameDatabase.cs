using UnityEngine;

// 所有静态设计数据集中管理，与运行时 GameData 分离
// 5天5区域，文案来自金海豚文案.docx
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
        "第五章：黎明港外"
    };

    // ============================================================
    // 5天收集事件
    // ============================================================
    public static readonly CollectionEventData[] collectionEvents =
    {
        new CollectionEventData { dayIndex=1, partsGained=1, description="我熟门熟路地在柜台角落找到了一个火花塞，放在他面前。\n\"大叔您看，这不就有嘛！\"\n\"哎？还真是！\"\n【零件+1】" },
        new CollectionEventData { dayIndex=2, partsGained=1, description="爱丽丝没有再打扰她，默默地从村子里堆积如山的杂物中，取走了一个用不上的零件。\n【零件+1】" },
        new CollectionEventData { dayIndex=3, partsGained=2, description="她一边思索，一边从一辆报废汽车的引擎里，拆下了两个还能用的活塞。\n【零件+2】" },
        new CollectionEventData { dayIndex=4, partsGained=3, description="在一处稍高的土坡上，一位旅人正深一脚浅一脚地游荡着。他的眼神里没有恐惧，没有悲伤，只有一片近乎透明的空洞。他忘了目的地，只记得要\"离开\"。\n【零件+3】" },
        new CollectionEventData { dayIndex=5, partsGained=3, description="远方，那座传说中的黎明港，就伫立在地平线上。它散发着一种柔和、纯净、令人无法直视的光芒。这是爱丽丝这一路走来，第一次见到如此明亮的颜色。\n【零件+3】" },
    };

    // ============================================================
    // 5个区域的出行文本
    // ============================================================
    public static readonly string[][] travelDialogues =
    {
        // 第一章：告别故土
        new string[] {
            "我叫爱丽丝。",
            "至少现在，我还记得这个名字。在这个连名字都会被偷走的世界里，能清晰地念出自己的名字，本身就是一种奢侈。",
            "妈妈告诉我，世界生了一场重病。人们叫它\"大失忆\"。",
            "它温柔地、不知不觉地，抽走人们脑海里的东西。先是昨天晚餐的味道，然后，是亲人的容貌，乃至于深爱之人的姓名。",
            "妈妈最后留给我的，除了那些故事，就是这个八音盒。",
            "\"这里面，装着我们最美好的时光，是任何人都偷不走的宝藏。\"",
            "\"但是……永远别逆转它。让这首摇篮曲，永远只为我们的回忆而响。\"",
            "妈妈走后，世界只剩下我一个人。她临终前，为我指明了唯一的方向——黎明港。",
            "带着妈妈留给我的房车，带着这个不能逆转的八音盒，穿过这片遗忘的荒原。",
            "我的旅程，现在开始了。"
        },
        // 第二章：静默之地
        new string[] {
            "好安静的村落。不过还有炊烟。",
            "村口的院落里，一个孩子正死死地抓着他母亲的手。可那位母亲只是呆呆地坐着，眼神空洞。",
            "\"妈妈……妈妈……\" 孩子似乎并不为母亲的冷漠而苦恼，只是满足地呢喃着。",
            "村里唯一的动静，来自一个冷漠的女人。她一言不发，只是机械地将干面包，送到每一个还\"活着\"的人手中。",
            "\"你好，请问这里是？\" \"……我是村长。\"",
            "她只记得自己是村长。她要给村民们做面包。这是她最后的执念。",
            "爱丽丝没有再打扰她。这个村庄的悲伤太过沉重。"
        },
        // 第三章：机械坟场
        new string[] {
            "爱丽丝驶入了一座彻底死亡的城市，一座机械的坟场。",
            "倾倒的钢铁与锈蚀的齿轮，勾勒出城市曾经的辉煌。",
            "房车老旧的车载广播里，毫无征兆地钻出一个断断续续的声音。",
            "\"……代价……不是灾难……是……选择……\"",
            "\"……核心……在吞噬……我们……主动献祭的……\"",
            "这几个词，让爱丽丝的心疯狂跳动起来。这座死城，或许隐藏着\"大失忆\"的最终秘密。"
        },
        // 第四章：泪之沼泽
        new string[] {
            "离开死气沉沉的机械坟场，爱丽丝的房车驶入了一片一望无际的灰色沼泽。",
            "传说，这里是\"大失忆\"中，人们流下的眼泪汇成的。",
            "爱丽丝遇到了一位旅人。他朝着与黎明港相反的方向，毫无目的地游荡着。",
            "\"你好，你也是旅行者吗？\" \"黎明港……那是哪里？我不知道。\"",
            "\"我要离开。我必须离开。\" \"离开哪里？\" \"不知道。不记得了。\"",
            "他转过身，继续迈着那空洞而坚定的步伐，走向未知的荒野。",
            "他的话，是一个警告吗？一个连自己为何逃离都忘记了的人，发出的警告。"
        },
        // 第五章：黎明港外
        new string[] {
            "历经了荒原、森林、死城与沼泽，爱丽丝的房车，终于抵达了旅途的终点。",
            "然而，越是靠近黎明港，爱丽丝心中的寒意就越重。",
            "城外没有繁华的入口，没有欢迎的人群。只有一片望不到边际的、无声的空白。",
            "这片空白之中，隐约漂浮着无数微光——那是被这座城市，从整个世界收集而来的，所有被遗忘的记忆。",
            "爱丽丝终于明白了。这座黎明港，并非大失忆的避难所。它就是大失忆本身。",
            "那个只记得离开的旅人，正是从这片光里逃出来的。他没有找到希望，只是被榨干了一切。",
            "一个宏大而温柔的意念笼罩了爱丽丝：\"融入我，献上你所有的记忆与自我，你将永远告别痛苦。\"",
            "这，就是旅途的终点。是所有选择，最后的答案。"
        }
    };

    // ============================================================
    // 5个危机事件（每区域1个，数值取原先配对中的第一个）
    // ============================================================
    public static readonly CrisisData[] crises =
    {
        // 第1天·告别故土
        new CrisisData {
            label = "1-1", area = 1,
            description = "奇怪，这桥怎么塌了？",
            optionA = new CrisisOption { label = "凭借技巧，小心通过", willCost=2, partsCost=1, carHPCost=4,
                log="第一天。\n离开了故乡。最后一次去大叔的杂货铺，他还是忘了我，却又觉得我\"面熟\"。\n我小心翼翼地通过了那座断桥。它以前那么坚固，是我们全镇的骄傲。现在它塌了，就像这里的每一个人一样，忘记了自己曾经的模样。\n妈妈，我出发了。我会带着我们的记忆，一直走下去。" },
            optionB = new CrisisOption { label = "加速冲下去", willCost=3, partsCost=0, carHPCost=8,
                log="第一天。\n为了赶路，我让房车冒险冲下了斜坡，它现在浑身是伤。对不起，我的老伙计。\n故乡在身后越来越远了。那个忘记进货的大叔，那些活在过去里的人们……我不敢回头看。\n只能往前走了。快点，再快点。" },
            reversalSelfCost = 15
        },
        // 第2天·静默之地
        new CrisisData {
            label = "2-1", area = 2,
            description = "爱丽丝站在原地，感到这个村庄的悲伤太过沉重。那个抓着母亲手的孩子，那个不知疲倦做着面包的村长……他们都被困在了自己最后的执念里。",
            optionA = new CrisisOption { label = "默默离开，不再打扰", willCost=4, partsCost=0, carHPCost=8,
                log="第二天。\n我最终还是选择了默默离开。那个抓着母亲手的孩子，那个不停做面包的村长……在他们残缺的世界里，依然\"正常\"地生活着。\n我想，我有什么权力去打破它呢？我的\"清醒\"，对他们而言，或许才是真正的残忍。\n这片森林的\"静默\"，不是因为死亡，而是因为一种深沉到极致的、无人回应的坚守。" },
            optionB = new CrisisOption { label = "帮村长分发面包", willCost=2, partsCost=3, carHPCost=14,
                log="第二天。\n我试着帮那位村长分发面包，可我很快就发现，这毫无意义。接过面包的人们，眼神空洞，有的甚至任由面包从手中滑落也毫无察觉。\n他们需要的不是食物，而是那份早已失去的\"生命\"。我的帮助，终究没能改变什么。\n但我不后悔。至少我尝试过，用行动去对抗这份安静。" },
            reversalSelfCost = 18
        },
        // 第3天·机械坟场
        new CrisisData {
            label = "3-1", area = 3,
            description = "爱丽丝的房车行驶到一段布满尖锐钢筋的狭窄路段。这些钢筋如同陷阱，稍有不慎，就会刺穿房车脆弱的核心管线。",
            optionA = new CrisisOption { label = "徒手清理路障", willCost=4, partsCost=2, carHPCost=7,
                log="第三天。\n广播里的话，像一根针，扎进了我的脑海。我一个人，用双手小心翼翼地清理着那条布满钢筋的路，脑子里却全是那几个词：\"代价\"、\"选择\"、\"主动献祭\"。\n如果这是真的，那意味着，这场毁灭了整个世界的灾难，从一开始，就是人们自己的选择。\n那么，妈妈给我的八音盒……它和这场灾难，究竟是什么关系？" },
            optionB = new CrisisOption { label = "加速冲过", willCost=3, partsCost=4, carHPCost=12,
                log="第三天。\n我没有时间去小心翼翼了。广播里的话太惊人了，我必须尽快弄清真相。我赌上一切，加速冲过了那段危险的路，车子又添了新的伤痕。\n这座死城就是最好的证据。它不是被战争摧毁的，而是被\"遗忘\"从内部掏空的。\n代价，核心，献祭……这一切的答案，究竟在哪里？" },
            reversalSelfCost = 20
        },
        // 第4天·泪之沼泽
        new CrisisData {
            label = "4-1", area = 4,
            description = "车轮陷入了沼泽的泥泞之中，越陷越深。那个旅人的空洞眼神还历历在目。",
            optionA = new CrisisOption { label = "用零件垫出一条路", willCost=5, partsCost=3, carHPCost=10,
                log="第四天。\n今天遇到一个旅人，他好像是从黎明港来的，却什么都不记得了。他忘了目的地，忘了原因，只记得要\"一直往前走下去\"。\n我用零件铺出了一条路，稳妥地离开了那片沼泽。可我的心却无法平静。他到底在黎明港经历了什么，才会变成那个样子？" },
            optionB = new CrisisOption { label = "让引擎过载冲出去", willCost=4, partsCost=0, carHPCost=16,
                log="第四天。\n那个旅人的样子，我忘不掉。他从黎明港来，却只记得要离开，眼神空洞得可怕。\n我让引擎过载，强行冲出了沼泽，只想尽快离开这里。他的话，是一个警告吗？\n但我不能回头。我必须去黎明港，亲眼看看，那里到底有什么。" },
            reversalSelfCost = 22
        },
        // 第5天·黎明港外——最终抉择
        new CrisisData {
            label = "5-1", area = 5,
            description = "爱丽丝握紧了胸前的八音盒。妈妈的嘱托、大叔的呢喃、村长的坚守、旅人的空洞……这一路的记忆，此刻都在她的脑海中，无比清晰地回响。\n\n一个宏大的意念许诺着：\"融入我，你将永远告别痛苦与遗忘。\"",
            optionA = new CrisisOption { label = "唱出妈妈的摇篮曲", willCost=5, partsCost=4, carHPCost=12,
                log="我找到了妈妈说的答案。\n答案不是一个地方，而是一首歌。\n只要还有人记得，还有人歌唱，那束火光，就不会熄灭。\n妈妈，我做到了。我会带着我们所有的回忆，一直唱下去。" },
            optionB = new CrisisOption { label = "走进那片光", willCost=6, partsCost=1, carHPCost=8,
                log="（日记本的最后一页，是一片无法辨认的、扭曲的乱码。）\n（在乱码的最后，似乎有人想写下什么，却只留下了一个残缺的墨点。）" },
            reversalSelfCost = 25
        },
    };

    // 逆转八音盒的日记文本（独立于正常日记）
    public static readonly string[] reversalLogs =
    {
        // 1-1
        "第一天。\n对不起，妈妈。第一天，我就食言了。\n那座断桥太麻烦了，我又实在好奇这个八音盒有什么用。我转动了旋钮，它就凭空修好了。可是现在，我努力想回忆起大叔的样子，那个憨厚的笑脸，却怎么也想不清了，只剩下一个模糊的轮廓。\n我用一段温暖的记忆，换来了一条平坦的路。这真的值得吗？",
        // 2-1
        "第二天。\n我不忍再看下去了。那个村庄的悲伤，那份令人窒息的执念，让我只想让这一切快点\"结束\"。于是，我转动了旋钮。\n奇妙的事情发生了。那个做面包的村长，眼神里的浑浊似乎散去了一些。可我抓住机会邀请她一起离开时，她却毫不犹豫地拒绝了。\n我也付出了代价。天空、森林，都只剩下一片灰色的概念。",
        // 3-1
        "第三天。\n这座压抑的死城让我喘不过气，我再次向那份诱惑低了头。这一次，我付出的代价，是\"希望\"。\n我看着黎明港的方向，心里那个曾经无比温暖、支撑我走到现在的念想，忽然就变得模糊而遥远。\n它真的存在吗？还是妈妈编造的一个善意的谎言？",
        // 4-1
        "（日记本上开始出现乱码）\n这片沼泽让XX觉得很不舒服，我转动了那个会发光的盒子，摆脱了它。\n白天好像遇到了一个人，他说他忘了要去哪里，只想离开。可\"旅人\"却想去那个叫黎明港的地方，那里好像有光。\n为什么那个人要离开有光的地方呢？真奇怪。算了，不想了。",
        // 5-1
        "（日记本上的字迹越来越轻，几乎难以辨认）\n到……了。\n光。很亮的光。\n妈妈，我……\n（后面的字迹彻底消失了）"
    };

    // ============================================================
    // 结局（文案来自金海豚文案.docx）
    // ============================================================
    public static readonly EndingData[] endings =
    {
        new EndingData { id=1, title="奇怪的吟游诗人", minSelf=85, minCarHP=80,
            desc="面对那片许诺着永恒安宁的光，爱丽丝摇了摇头。\n她静静地站在那里，然后，唱起了那首歌。那首妈妈在无数个深夜为她哼唱的、装满了最美好时光的摇篮曲。\n歌声很轻，却清晰无比。歌声里，有故乡杂货铺大叔的憨厚，有森林里村长那份沉重的责任，有她对妈妈无尽的思念……\n奇迹发生了。一抹微弱的、却无比真实的色彩，从爱丽丝的脚下，缓缓晕染开来。\n她没有摧毁黎明港，也没能终结这场灾难。\n她只是用自己的歌声，唤醒了那些被献祭的记忆。她成了一个奇怪的吟游诗人，一个行走在黯淡世界里，用歌声播撒记忆与色彩的旅人。" },
        new EndingData { id=2, title="坚定的前行者", minSelf=72, minCarHP=65,
            desc="爱丽丝在那片光前，停下了脚步。她守住了自己，守住了那份完整的、未曾交易过的记忆。\n她记得故乡，记得妈妈，记得这一路上遇到的每一个人。\n她转过身，背着包，一步一步，蹒跚地离开了这片许诺着安宁的光。\n她保全了自己的灵魂，但现实的旅途，已榨干了她所有的物质。前路依旧黯淡，未来一片渺茫。但她还是那个完整的爱丽丝，带着尊严，和一身的伤痕，继续着这场看不到希望的流浪。" },
        new EndingData { id=3, title="疲惫的旅人", minSelf=58, minCarHP=48,
            desc="爱丽丝在那片光前，停下了脚步。她回头看了一眼自己那辆浑身是伤、几乎散架的房车。\n它陪着她，用尽了最后一丝力气，才走到了这里。\n爱丽丝没有走进那片虚假的光明。她转过身，一步一步，蹒跚地离开了。她守住了自己，没有向那个盒子低头。\n我很累，但我不后悔。至少，我还是我。带着我们所有的回忆，哪怕只能这样蹒跚地，一直走下去。" },
        new EndingData { id=4, title="褪色的幸存者", minSelf=43, minCarHP=33,
            desc="她低头看了看自己的手，又看了看眼前那片光，眼神里是一片和这世界一样的、平静的黯淡。\n她还记得自己的名字，还记得要去黎明港。可她已经想不起来，天空到底是什么颜色，也想不起来，妈妈那首摇篮曲，完整的调子究竟是怎样的了。\n在漫长的旅途中，她用自己的一部分，换取了一次次的轻松通过。\n她走进了荒原，成了一个褪色的旅人。她的房车还算完好，可她的灵魂，却像一张被反复水洗的旧照片，早已失去了鲜活的色彩。" },
        new EndingData { id=5, title="蹒跚的归途", minSelf=28, minCarHP=18,
            desc="她站在那片光前，想不起来自己为什么要来这里。\n八音盒转了很多次。每次转动，都会带走一些东西。现在，那些东西已经所剩无几了。\n她还记得\"黎明港\"这个名字，但不记得为什么它如此重要。她麻木地看了一眼那片光，然后像那个曾经警告过她的旅人一样，转身离开了。\n她活着，却与那些活着的空壳，只有一线之隔。" },
        new EndingData { id=6, title="空壳的幻影", minSelf=12, minCarHP=1,
            desc="她几乎什么都想不起来了。\n那个会发光的盒子，那个叫\"妈妈\"的概念，那个叫\"黎明港\"的词语——它们都还在，但像隔着一层厚厚的浓雾，怎么也抓不住。\n她只知道，前面有光。很亮的光。\n她差一点就走进了那片光。但她没有。她只是站在那里，像一棵被风吹空了心的树，不知道自己为什么还在坚持。也许，只是习惯了。" },
        new EndingData { id=7, title="消失之影", minSelf=1, minCarHP=0,
            desc="房车彻底报废在了荒原上。\n爱丽丝站在路边，看着地平线上那遥不可及的灯火。她走不到那里了。\n但她还活着，还记得自己是谁。在这片遗忘的荒原上，这或许，就已经是一种胜利。" },
        new EndingData { id=8, title="静默之人", minSelf=0, minCarHP=-1,
            desc="它站在那片光前。\n它已经不记得自己叫什么名字了。不记得为什么会来到这里，也不记得那个会发光的盒子，究竟有什么用。\n它只记得，前面有光，很亮的光。\n于是，它将手中那个冰冷的、不再发光的盒子，连同自己最后残存的一点什么，一起，交付给了那片光。\n没有痛苦，没有挣扎。它的身影，缓缓地、平静地，融入了那片永恒的空白之中。\n世界的大失忆，因为又一个自我的献祭，变得更加深沉，也更加完美了。" },
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

    public static string GetReversalLog(int dayIndex)
    {
        int i = Mathf.Clamp(dayIndex, 0, reversalLogs.Length - 1);
        return reversalLogs[i];
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
        return endings[7];
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
    public float saturation;
}
