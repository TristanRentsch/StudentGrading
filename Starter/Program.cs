using System;

// initialize variables - graded assignments 
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] {92, 89, 81, 96, 90};
int[] emmaScores = new int[] { 90, 85, 87, 98, 68};
int[] loganScores = new int[] { 90, 95, 87, 88, 96};

int[][] studentScores = new int[][] {sophiaScores, andrewScores, emmaScores, loganScores };
string[] students = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

Console.WriteLine("Student\t\tGrade\n");

for(int i = 0; i < studentScores.Length; i++){
    int[] scores = studentScores[i];
    int sum = 0;
    foreach (int score in scores){
        sum += score;
    }

    decimal average = (decimal)sum / scores.Length;
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
    Console.WriteLine($"{students[i]}:\t\t{average}\t{grade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
