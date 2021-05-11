<table border=0><tr><td valign="top">
<h1>WMI_Monitor_Csharp</h1>
A "System Monitor" project using "WMI" and "Open Hardware Monitor".<br />
Written in C-sharp by Mark Becker in 2012, fork by Mohammad Yaser Ammar in 2021

This project is my desire to experience developing my skills and supporting open source projects, this is the second project that I have been working on for GitHub!

Project fork from:  [https://github.com/markbecker/WMI_Monitor_Csharp](https://github.com/markbecker/WMI_Monitor_Csharp)

# Improvements

**Correcting problems to run in 2021**  
The project from 2012 was therefore built on libraries that need to be changed or updated, in addition to the nature of the system that was tried on Windows 7, but now this system has stopped supporting it, I have tried the changes to work in the best possible way with Windows 10.

# Problems and method of fix

1 - When opening the project for the first time, we get about 116 errors, as in the picture

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%20of%20the%20first%20problem.png "Picture of first problem")

  Do not worry, this is because the program version differed from 2010 to 2019, so the handling of libraries is a little different, the solution to this problem is simply to enter the library store (one of the advantages of Visual Studio 2019 is the ease of downloading and updating libraries) Store Picture of NuGet Packages we enter it like the image

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%20of%20NuGet%20Packges.png "Picture of steps to open NuGet Packages")


Then we are looking for download this library as in the picture

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%20to%20solve%20the%20first%20problem.png "Picture to solve the first problem")


---
2 - Now with these problems is to modify the method of queries in the code because an error such as

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%20of%20the%20second%20problem.png "Picture to solve the second problem")

Simply the first initial solution is to make a comment when calling the method to limit the problem

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%20to%20inital%20solve%20the%20second%20problem.png "Picture of initial solve of second problem")

---
3 - This problem is similar to the previous one, but I will explain the reasons for it because it depends on the device that the driver contains or not. 

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%20of%20the%20third%20problem.png "Picture of initial solve of third problem")

When opening the tool at the highest level it shows us blank information, but this is with a comment of course

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%20to%20inital%20solve%20the%20third%20problem.png "Picture of initial solve of third problem")

To solve it, we will go through a series of steps to understand that, if you encounter a similar problem, dear reader and programmer, with WMI, how you think to solve it 🤔.

We notice here, via the tool that examines the queries for that, that the query in the code does not exist basically as in the picture (I will explain the tool in the next section)

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%201%20when%20solve%20the%20third%20problem.png "Picture 1 when solve")

When modifying to find the determinant by itself and a direct query is still the error, why?

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%202%20when%20solve%20the%20third%20problem.png "Picture 2 when solve")

If we try in another system, for example Windows Server 2019, we notice that it works with the tool without problems, as well as if we run the program on it

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%203%20when%20solve%20the%20third%20problem.png "Picture 3 when solve")

The solution I think with Windows 10 is to download features of WMI and SNMP from settings

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%204%20when%20solve%20the%20third%20problem.png "Picture 4 when solve")


---
# A utility for queries to WMI

Using a utility to scan directly on Windows devices and for queries, are they present or not before checking the code.

To enter it, run from the Windows button with the letter R.
Then we call the field we want and inquire about the specific query as I explained in the picture
![alt text](hhttps://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%20of%20helping%20tool.png "WMI tool")

---
The explanation of the program has been completed

![alt text](https://github.com/MohammadYAmmar/WMI_Monitor_Csharp/blob/feature/Fix-to-run-in-2021/Picture%20of%20about%20program.png "About program")



---
My GitHub:  
[https://github.com/MohammadYAmmar](https://github.com/MohammadYAmmar)  
My LinkedIn:  
[https://www.linkedin.com/in/mohammad-y-ammar/](https://www.linkedin.com/in/mohammad-y-ammar/)

This site is nice for writing description [stackedit](https://stackedit.io/)


Thank you for reading all of this to benefit you instead of just copying and pasting ✂!

**The part in which Mohammad Yaser Ammar wrote has ended**



## Description of the original project without modification:

<table border=0><tr><td valign="top">
<h1>WMI_Monitor_Csharp</h1>
A "System Monitor" project using "WMI" and "Open Hardware Monitor".<br />
Written in C-sharp by Mark Becker
<hr>
<ul>
<font size='4'><b>Features</b></font><ul>
<li>Starts in sytem tray
<li>Standalone application
<li>Short and Long Form
<li>Low processor usage
<li>Simple to use
</ul><br/>
<font size='4'><b>Development Purpose</b></font><ul>
<li>Needed better, light weight, set of system monitors used during application development.
<li>Windows gadgets were not complete enough.
<li>Explore C# application development in Visual Studio 2010.
<li>Explore using WMI and Open Hardware Monitor.
</ul><br/>
<font size='4'><b>Developed and tested on...</b></font><ul>
<li>Desktop:<ul>
<li>OS - Windows 7 Professional 64-bit
<li>CPU - Intel Core i5 760 @ 2.80GHz
<li>MB - ASUS P7P55D-E Pro
<li>VC - ATI Radeon HD 5750
</ul>
<li>Laptop:<ul>
<li>Lenovo ThinkPad T61
<li>OS - Windows 7 Professional 64-bit
<li>CPU - Intel Core 2 Duo T7500
<li>VC - NVIDIA Quadro NVS 140M
</ul></ul></ul>
<hr>
<ul>
<font size='4'><b>What is WMI?</b></font><ul>
<li>Windows Management Instrumentation (WMI) is the infrastructure for management <br />
data and operations on Windows-based operating systems. You can write WMI <br />
scripts or applications to automate administrative tasks on remote computers <br />
but WMI also supplies management data to other parts of the operating system <br />
and products, for example System Center Operations Manager, formerly Microsoft <br />
Operations Manager (MOM), or Windows Remote Management <br />
<li><a href="http://msdn.microsoft.com/en-us/library/aa393964(v=vs.85)" target=blank>More info from MS</a>
</ul><br/>
<font size='4'><b>What is Open Hardware Monitor?</b></font><ul>
<li>The Open Hardware Monitor is a free open source software that monitors <br />
temperature sensors, fan speeds, voltages, load and clock speeds of a computer.<br />
<li><a href="http://openhardwaremonitor.org/" target=blank>More info from OHM</a>
</ul></ul>
<hr>
<ul>
<font size='4'><b>To Install...</b></font><ul>
<li>Both "WMI_Monitor_Csharp" and "Open Hardware Monitor" are stand-alone applications.
<li>Just click the .exe files to get running
<li>The .exe location is here<br/>
<code>...\WMI_Monitor_Csharp\WMI_Monitor_Csharp\bin\x64\Debug\WMI_Monitor_Csharp.exe</code>
<li>This .exe was compiled for 64 bit systems.
<li>Adjust and recompile if using a 32 bit system.
</ul><br/>
<font size='4'><b>System Requirements</b></font><ul>
<li>Windows OS
<li>Open Hardware Monitor running in background
<li>WMI is already installed in Windows systems
</ul></ul><br/><br/>
</td>
<td valign="top">
<a href="https://github.com/markbecker/WMI_Monitor_Csharp/raw/master/screenshot.png" target=blank>
<img border=1 src="https://github.com/markbecker/WMI_Monitor_Csharp/raw/master/screenshot.png" height="216" width="128" alt="Screenshot 1"/></a><br />
<a href="https://github.com/markbecker/WMI_Monitor_Csharp/raw/master/screenshot.png" target=blank>Click for larger</a><br /><br />
<a href="https://github.com/markbecker/WMI_Monitor_Csharp/raw/master/screenshot2.png" target=blank>
<img border=1 src="https://github.com/markbecker/WMI_Monitor_Csharp/raw/master/screenshot2.png" height="474" width="128" alt="Screenshot 2"/></a><br />
<a href="https://github.com/markbecker/WMI_Monitor_Csharp/raw/master/screenshot2.png" target=blank>Click for larger</a><br />
</td></tr></table>
