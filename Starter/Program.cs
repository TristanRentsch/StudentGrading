using System;

// Represents the number of non-extra credit assignments.
int examAssignments = 5;

// Assignment grades for each student
// The First X assignments are the exam assignments.
// All assignments after these are extra credit.
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

int[][] studentScores = new int[][] {sophiaScores, andrewScores, emmaScores, loganScores, beckyScores, chrisScores, ericScores, gregorScores};

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

for(int i = 0; i < studentScores.Length; i++){
    int[] scores = studentScores[i];
    int extraCredSum = 0;
    int examSum = 0;
    for(int n = 0; n < scores.Length; n++){
        int score = scores[n];

        if(n >= examAssignments){
            extraCredSum += score;
        }
        else{
            examSum += score;
        }
    }

// Determine Letter Grade

    decimal average = (examSum + (extraCredSum / 10m)) / examAssignments;
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

    decimal examScore = (decimal)examSum/examAssignments;
    decimal extraCredit = (decimal)extraCredSum/(scores.Length-examAssignments);
    decimal extraCreditPts = average - examScore;

    Console.WriteLine($"{studentNames[i]}\t\t{examScore}\t\t{average}\t{grade}\t{extraCredit}({extraCreditPts} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
