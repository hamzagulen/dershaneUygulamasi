using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement("dershane-info")]
public class DershaneInfoTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        output.Attributes.SetAttribute("class", "text-center");

        var content = @"
        
            <h2>Dershane Otomasyonu Uygulaması Hakkında</h2>
            <p>Dershane otomasyonu, eğitim kurumlarının yönetim süreçlerini kolaylaştırmak ve daha verimli hale getirmek amacıyla tasarlanmış bir uygulamadır. Bu uygulama, öğretmenlerin, öğrencilerin ve kursların yönetimini sağlamak için çeşitli özellikler sunmaktadır.</p>
            <h3>Öğretmen Yönetimi:</h3>
            <ul>
                <p>Yeni öğretmen ekleyebilme ve bilgilerini güncelleyebilme.</p>
                <p>Öğretmenlere ait ders branşlarını belirleyebilme ve güncelleyebilme.</p>
            </ul>
            <h3>Öğrenci Yönetimi:</h3>
            <ul>
                <p>Yeni öğrenci kaydı oluşturabilme ve öğrenci bilgilerini güncelleyebilme.</p>
                <p>Öğrenci performansını izleme ve raporlama.</p>
            </ul>
            <h3>Kurs Yönetimi:</h3>
            <ul>
                <p>Yeni kurs kaydı oluşturabilme ve kurs bilgilerini güncelleyebilme.</p>
                <p>Kurs, Öğrenci ve Öğretmen ilişkileri.</p>
            </ul>
        ";

        output.Content.SetHtmlContent(content);
    }
}
