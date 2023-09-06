using System;
using System.Collections.Generic;

namespace System{
 public class MCShater{

    public static void Main(String[] args){
Book mybook = new Book("My Book", new List<Chapter>()
{
    new Chapter("Chapter 1", new List<Page>()
    {
        new Page(MyNotes.VariablesPageOne),
        new Page(MyNotes.VariablesPageTwo),
    }),
    new Chapter("Chapter 2", new List<Page>()
    {
        new Page(MyNotes.ClassPageOne),
        new Page(MyNotes.ClassPageTwo),
    })
});

mybook.Start();

}}}