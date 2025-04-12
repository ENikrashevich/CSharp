using Adapter;
using Adapter.HomeCats;
using Adapter.WildCats;

IHomeCat barsik = new YardCat("Барсик");
IHomeCat pushok = new MaineCoon("Пушок", "Котов", "Илья");

IWildCat onca = new PantheraOnca("Y0000085");

PrintDocument(barsik);
PrintDocument(pushok);
PrintDocument(new AdapterWildCatToHomeCat(onca));

void PrintDocument(IHomeCat cat)
{
    Console.WriteLine("*Паспорт кошки*\n" +
        "Фамилия владельца:\t{0}\n" +
        "Имя Владельца:\t{0}\n" +
        "Имя Кошки:\t{0}\n" +
        "Порода Кошки:\t{0}\n",
        cat.SurnameOfOwner,
        cat.NameOfOwner,
        cat.NameOfHomeCat,
        cat.DescriptionOfHomeCat);
}