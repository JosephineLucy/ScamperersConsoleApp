# Todd Comments

This is much nicer, but we can still make it cleaner.

1. Sort out the file structure. You could ask chatGPT for a C# file structure. I suggest something like this for now:

```
> AppName // This is your root project folder
  > AppName // This would be your source folder (named same as project)
    > Models // contains model and entity classes
      OfficeManager.cs
      Employee.cs
    Program.cs // in source folder, but not in models
  .gitignore // in project root, but not in source
  README.md
  todd-comments.md
```

2. Your OfficeManager has a public class and an internal method. Is there a reason for that? It might be best to use one or the other. You might want to ask ChatGPT about the differences, but I think 'internal' means it can be used only by this project and 'public' means it can be used from outside the project. When a C# project gets compiled/built, it becomes a .dll or .exe file. If the class is public, other dlls/exes can talk to them. If they are internal, they can't. Languages like JavaScript only have the public option.

You have the opposite going on in Employee. internal class and a public property and constructor.

3. Just as an FYI, in case you don't know, you could create those employees by using the object initialiser approach too:

`var todd = new Employee {FirstName = "Todd"};`

Here, rather than using a constructor, it creates the object and initialises the public properties. Doing it with constructors is perfectly fine, I just thought I'd mention this nice little C# feature.

4. Another point that doesn't much matter, instead of:

`OfficeManager gunther = new OfficeManager();`

You could go:

`var gunther = new OfficeManager();`

In general, when you assign a value to a variable, you don't need to worry about explicitly declaring the type if it is obvious by the declaration what the type is. We use 'var' here because the 'new OfficeManager()` makes it obvious that it's an OfficeManager type. This is especially helpful for lists and other generics

`var longNamedList = new SortedList<VeryLongNamedList>();`

Is nicer than:

`SortedList<VeryLongNamedList> longNamedList = new SortedList<VeryLongNamedList>();`

Also, I wonder if it would help if we changed gunthar's name to todd?

Being as all these suggestions are either irrelevant or easy to fix, I figure I'll send another deliverable/directive:

Directive 2:

As a user, I would like the office manager to interview each job applicant prior to welcoming them to the company so that we don't accidentally employ anyone that doesn't deserve a job.

We should be able to specify how many employees we are looking for, then, during the interview process, each applicant should be given a number representing how well they did. The highest scoring applicants will then be welcomed to the company.
