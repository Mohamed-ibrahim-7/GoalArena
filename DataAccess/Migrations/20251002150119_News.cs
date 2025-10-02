using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class News : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO News (Title, Content, PublishedDate, playerId, TeamId, MatchId, ImageNews)VALUES (N'الأهلي يحقق فوزاً صعباً على بيراميدز ويتصدر القمة',         N'في مباراة مثيرة، تمكن النادي الأهلي من الفوز بهدف نظيف على نادي بيراميدز، ليوسع الفارق في صدارة ترتيب الدوري المصري الممتاز.',         '2025-10-01 19:30:00',         NULL,             1,               20,            N'1.Png');INSERT INTO News (Title, Content, PublishedDate, playerId, TeamId, MatchId, ImageNews)VALUES (N'الزمالك يكتفي بالتعادل الإيجابي أمام فيوتشر',         N'فشل الزمالك في الحفاظ على تقدمه واكتفى بالتعادل 1-1 أمام فيوتشر، ليفقد نقطتين ثمينتين في مشوار المنافسة.',         '2025-09-30 21:00:00',         NULL,         2,                 21,               N'2.png');INSERT INTO News (Title, Content, PublishedDate, playerId, TeamId, MatchId, ImageNews)VALUES (N'الإسماعيلي يتنفس الصعداء بفوز أول هذا الموسم بفضل نجمه',         N'حقق الدراويش فوزهم الأول بفضل هدف قاتل من اللاعب شكري نجيب (وهمي)، ليقفزوا خارج منطقة الخطر مؤقتاً.',         '2025-10-02 17:15:00',         15,              3,              22,         N'3.Png');INSERT INTO News (Title, Content, PublishedDate, playerId, TeamId, MatchId, ImageNews)VALUES (N'منافسة شرسة على لقب هداف الدوري: أحمد ياسر ريان يتألق',         N'ارتفع رصيد المهاجم أحمد ياسر ريان إلى 7 أهداف، ليقترب من صدارة الهدافين بعد ثنائية في شباك حرس الحدود.',         '2025-10-01 12:00:00',         22,               10,                NULL,        N'4.Png');INSERT INTO News (Title, Content, PublishedDate, playerId, TeamId, MatchId, ImageNews)VALUES (N'تأجيل مباراة الأهلي والمقاولون العرب بقرار من لجنة المسابقات',         N'أعلنت رابطة الأندية المصرية المحترفة عن تأجيل مباراة الأهلي والمقاولون العرب لأسباب تتعلق بجدول المباريات الأفريقية.',         '2025-09-29 15:45:00',         NULL,         NULL,            23,               N'5.Png');INSERT INTO News (Title, Content, PublishedDate, playerId, TeamId, MatchId, ImageNews)VALUES (N'الاتحاد السكندري يختتم تدريباته استعداداً لمواجهة فاركو',         N'أنهى زعيم الثغر استعداداته لمباراة الجولة القادمة بتركيز عالٍ من اللاعبين والجهاز الفني.',         '2025-10-02 10:30:00',         NULL,         6,                24,               N'6.Png');INSERT INTO News (Title, Content, PublishedDate, playerId, TeamId, MatchId, ImageNews)VALUES (N'صدمة في صفوف إنبي: نجم الفريق يغيب لمدة شهرين بسبب الإصابة',         N'أكد الجهاز الطبي لنادي إنبي تعرض اللاعب أيمن أشرف (وهمي) لتمزق سيغيبه عن الملاعب لفترة طويلة.',         '2025-09-28 22:10:00',         30,              7,              NULL,        N'7.png');INSERT INTO News (Title, Content, PublishedDate, playerId, TeamId, MatchId, ImageNews)VALUES (N'الداخلية يعلن عن التعاقد مع مدير فني أجنبي جديد',         N'أتم نادي الداخلية تعاقده مع المدرب البرتغالي \"جوزيه مينديز\" لقيادة الفريق في الفترة القادمة أملاً في تحسين النتائج.',         '2025-10-01 16:00:00',         NULL,         12,               NULL,        N'8.Png');INSERT INTO News (Title, Content, PublishedDate, playerId, TeamId, MatchId, ImageNews)VALUES (N'جائزة أفضل حارس مرمى في الجولة تذهب لحارس طلائع الجيش',         N'اختير الحارس محمد بسام (وهمي) كأفضل حارس في الجولة الماضية بعد تصدياته المذهلة التي أنقذت فريقه من الهزيمة.',         '2025-09-30 14:00:00',         45,               8,                 NULL,        N'9.png');INSERT INTO News (Title, Content, PublishedDate, playerId, TeamId, MatchId, ImageNews)VALUES (N'عودة الجماهير للمدرجات تزيد من حماس مباريات الدوري',         N'شهدت مباريات الجولة الأخيرة حضوراً جماهيرياً كبيراً، مما أضفى أجواء مميزة على المنافسات وزاد من قوة الدعم للأندية.',         '2025-10-02 09:00:00',         NULL,         NULL,         NULL,        N'10.Png');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE News");
        }
    }
}
