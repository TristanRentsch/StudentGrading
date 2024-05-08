using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[][] studentScores = new int[][] {sophiaScores, andrewScores, emmaScores, loganScores, beckyScores, chrisScores, ericScores, gregorScores};

Console.WriteLine("Student\t\tGrade\n");

for(int i = 0; i < studentScores.Length; i++){
    int[] scores = studentScores[i];
    int sum = 0;
    for(int n = 0; n < scores.Length; n++){
        int score = scores[n];
        sum += n < examAssignments ? score : (score / 10);
    }

    decimal average = (decimal)sum / examAssignments;
    string grade;
    if (average >= 97){
        grade = "A+";
    }
    else if (average >= 93){
        grade = "A";
    }
    else if(average >= 90){
        grade = "A-";
    }
    else if(average >= 87) {
        grade = "B+";
    }
    else if(average >= 83) {
        grade = "B";
    }
    else if(average >= 80) {
        grade = "B-";
    }
    else if(average >= 77) {
        grade = "C+";
    }
    else if(average >= 73) {
        grade = "C";
    }
    else if(average >= 70) {
        grade = "C-";
    }
    else if(average >= 67) {
        grade = "D+";
    }
    else if(average >= 63) {
        grade = "D";
    }
    else if(average >= 60) {
        grade = "D-";
    }
    else {
        grade = "F";
    }
    Console.WriteLine($"{studentNames[i]}:\t\t{average}\t{grade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
