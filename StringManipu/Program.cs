// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("###### Test String #######");
string exampleString = "I went to the store to get some peach soda";
Console.WriteLine(exampleString);

Console.WriteLine("##### Individual Characters ########");
char findLetter = exampleString[20];
Console.WriteLine(findLetter);

Console.WriteLine("#### Concat ####");
string a = "I went to the store to get some peach soda,";
string b = " then I realized when I got there I actually would like some strawberry soda";
Console.WriteLine( a + " " +b );
Console.WriteLine(a);
Console.WriteLine(b);


Console.WriteLine("########## To Upper Case #######");
string abcd = "abcd";
Console.WriteLine(abcd.ToUpper());

Console.WriteLine("######## To Lower Case #########");
string GOLDFISH = "GOLDFISH";
Console.WriteLine(GOLDFISH.ToLower());


Console.WriteLine("####### Trim ########");
string controlSpace = "             Upon           A Time       ";
Console.WriteLine("Once" + controlSpace + "long ago");
Console.WriteLine("Once" + controlSpace.TrimStart() + "long ago");
Console.WriteLine("Once" + controlSpace.TrimEnd() + "long ago");
Console.WriteLine("Once" +controlSpace.Trim() + "long ago");

Console.WriteLine("### Substrings ###");
string goodSpace = "I wonder what good recipes I could come up with";
Console.WriteLine( goodSpace.Substring(12));

