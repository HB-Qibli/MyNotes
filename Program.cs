using System;
using System.Collections.Generic;

namespace System{
 public class MCShater{

    public static void Main(String[] args){
Book mybook = new Book("My Book", new List<Chapter>()
{
    new Chapter("Variables", new List<Page>()
    {
        new Page(MyNotes.VariablesPageOne),
        new Page(MyNotes.VariablesPageTwo),
    }),
    new Chapter("Classes", new List<Page>()
    {
        new Page(MyNotes.ClassPageOne),
        new Page(MyNotes.ClassPageTwo),
    }),
    new Chapter("Class inheritance", new List<Page>()
    {
        new Page(MyNotes.InheritancePageOne),
        new Page(MyNotes.InheritancePageTwo),
    })
});

mybook.Start();

}}}