# What is Coding Trainer?

Coding trainer is a project to encourage users to code more and not procrastinate. This is done by incentivizing users to work on their code in order to access certain "fun" programs.

# How does it work?

The program is a [daemon](https://en.wikipedia.org/wiki/Daemon_(computing)) that monitors opened processes. For example, if the user opens a game, a game client or other specified programs, the application will be forcefully closed and a warning will pop up, such as 
<br>"This application cannot be loaded. You need 2 more code credits"

# Inspiration

This was inspired by the Oasis fitness trainer in the book, [Ready Player One](https://en.wikipedia.org/wiki/Ready_Player_One). Where Wade had to do a certain amount of exercise daily to enable access to the Oasis. In the end he became healthier and fitter. 

# How can you help?

Fork or email me at Info@IronPhreak.com
<br>Add your pull request, if it meets standards and adds functionality to the program they will be added.

I welcome any suggestions and ideas


# Coding-Trainer UI

Despite the fact that this program is a daemon process, users have asked that it have a UI to select the programs that they wish to have locked from easy access. Below is the current design. Below that are some possible suggested TODOs for the UI itself. Bullet points below a TODO are possible resources that may be useful.

![UI_Coding_trainer](./Coding Trainer.png)
- [ ] Credits will be earned hourly (Determine how many per hour)
- [ ] Make sure that an IDE is of focused window in order for Credits to be earned
- [ ] Use a Credit to unlock something of particular desire
- [ ] Add more options to 'File'
- [ ] Add more to 'Help'
- [ ] Add more menus?
- [ ] Populate white box with programs running currently
- http://doc.qt.io/qt-4.8/qprocess.html
- http://www.bogotobogo.com/Qt/Qt5_QListView_QStringListModel_ModelView_MVC.php
- [ ] Allow user to select the programs in white box
- Can be done by adding a drop down box, refer to bogotobogo link
- [ ] Connect C# with Qt somehow? Or change the framework completely?

# Programs required
- Qt\Qt5.7.0\...\qtcreator.exe
<br><br>To begin working on this program download from this website
<br>https://www.qt.io/download-open-source/#section-2
<br>It is imperative that you have MinGW or some C compiler or this program is rendered useless. 
<br>The provided link comes with the necessary Compiler built in, you should be ok.
<br><br>Another approach: download the Qt Designer and work on the UI seperate from the Code.
<br>The only caveat is that there will be no inter connected talking between *.ui *.cpp and *.h files

<br> IDE: I'm using Visual Studio Community 2015
