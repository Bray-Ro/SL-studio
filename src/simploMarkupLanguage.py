#Simplo Markup Language, for use with the simplo file search system by Rohan Samra-O'Neill
import sys
from pathlib import Path
import tkinter 
global file
global line_running
global running_line
global program
global root
line_running = 0
# get arguments 
for arg in sys.argv:
    # get contents of .sml file and format it
    file_val = Path(arg).read_text()
    file_val = file_val.split("#END")
    
    del file_val[0:0]

    file_val = file_val[0]
    program = file_val.split(";")
    root = tkinter.Tk()

    root.attributes('-fullscreen', True)  



    def start():
       
        running_line = program[line_running]
        if (running_line[:4] == "h1: "):
            running_line = running_line.replace(running_line[:4], " ")
            w = tkinter.Label(root, text="Hello Tkinter!")
            w.pack()
            w2 = tkinter.Label(root, text="Hellwdwedo Tkinter!")
            w2.pack()

                            
      
    start()
root.title(arg)
root.mainloop()
#END
