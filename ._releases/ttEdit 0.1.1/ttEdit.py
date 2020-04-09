from graphics import *
import json
import random
import os

def Rect (x, y, w, h):
    return Rectangle(Point(x, y), Point(x + w, h + y))

def Start ():
    win = GraphWin("ttEdit viewer 0.1.1", 1000, 450)  # give title and dimensions
    #attempt to start writer
    try:
        os.startfile ("ttEditWriter.exe")
    except:
        print()
        
    Main (win)

def Main(win):

    # get all the lines
    lines = []
    with open ("lines.txt") as f:
        for l in enumerate (f):
            lines.append (l[1].replace ("\n", ""))

    # get all the subjects
    subjects = dict()
    with open ("timetable.json", "r") as f:
        subjects = json.load (f)

    # colours!
    GRAY = color_rgb(84, 84, 84)

    # building the timetable
    timetable = dict()
    days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday"]
    period = 0
    for dayID in range (len(days)):
        activities = []
        day = days[dayID]
        for p in range (8):
            # account for break times
            if p == 2 or p == 5:
                activities.append (("", "", "", GRAY))
            else:
                currentLine = int(lines[period])
                currentSubject = subjects[currentLine - 1]
                col = GRAY
                try:
                    if (currentSubject["colour"] != [0, 0, 0]):
                        col = color_rgb(currentSubject["colour"][0], currentSubject["colour"][1], currentSubject["colour"][2])
                except:
                    print ()
                activities.append ((currentLine, currentSubject["subject"], currentSubject["room"], col))
                period+=1

        timetable[day] = activities

    Drawables = []

    # drawing everything

    # Divide the width into 6 parts
    CellWidth = win.width / 6
    CellHeight = 50

    # Draw left hand
    ref = ["1\n(10:30 - 11:10)", "2\n(11:10 - 11:50)", "break (11:50 - 12:00)", "3\n(12:00 - 12:40)", "4\n(12:40 - 1:20)", "break (1:20 - 2:00)", "5\n(2:00 - 2:40)", "6\n(2:40 - 3:20)"]
    for r in range(len(ref)):
        LHRect = Rect (0, CellHeight * r + CellHeight, CellWidth, CellHeight)
        LHRect.setFill(GRAY)
        Drawables.append(LHRect)
        LHText = Text(Point(CellWidth / 2, CellHeight * r + CellHeight * 1.5), ref[r])
        LHText.setFill ("white")
        Drawables.append (LHText)

    # Draw classes with days
    pointlessrect = Rect(0, 0, CellWidth, CellHeight)
    pointlessrect.setFill(GRAY)
    Drawables.append (pointlessrect)
    for dayN in range (5):
        # days
        dayHead = Rect (CellWidth * (dayN + 1), 0, CellWidth, CellHeight)
        dayHead.setFill(GRAY)
        Drawables.append(dayHead)
        dayText = Text (Point ((CellWidth * (dayN + 1)) + CellWidth / 2 , CellHeight / 2), days[dayN])
        dayText.setTextColor("white")
        Drawables.append (dayText)

        for t in range(len(timetable[days[dayN]])):
            p = Point(CellWidth * (dayN + 1) + CellWidth / 2, CellHeight + CellHeight / 2 + CellHeight * t)
            subHead = Rect(CellWidth * (dayN + 1), CellHeight + CellHeight * t,CellWidth, CellHeight)
            subHead.setFill(timetable[days[dayN]][t][3])
            Drawables.append(subHead)
            subText = Text(p, str(timetable[days[dayN]][t][0]) + " " + str(timetable[days[dayN]][t][1]) + " " + str(timetable[days[dayN]][t][2]))
            subText.setSize(15)
            Drawables.append(subText)

    for drawable in Drawables:
        drawable.draw (win)

    while True:
        win.getMouse()
        Main(win)


Start()
