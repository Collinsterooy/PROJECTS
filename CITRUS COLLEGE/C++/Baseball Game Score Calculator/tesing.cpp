

#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>
#include <cmath>

using namespace std;

int teamScore(string teamName);
int extraInnings(string teamName);


int main()
{


    string teamA;
    string teamB;
    int totalScoreA;
    int totalScoreB;
    int extraScoreA;
    int extraScoreB;

    cout << "Enter the name of the first Baseball team: ";
    getline(cin, teamA);
    cout << endl;

    cout << "Enter the name of the second Baseball team: ";
    getline(cin, teamB);
    cout << endl;

    totalScoreA = teamScore(teamA);
    cout << endl;

    totalScoreB = teamScore(teamB);
    cout << endl;


    while (totalScoreA == totalScoreB)
    {
        cout << " It is a tie game! Game is extended to 3 innings";
        cout << endl;

        extraScoreA = extraInnings(teamA);
        cout << endl;

        extraScoreB = extraInnings(teamB);
        cout << endl;
        totalScoreA += extraScoreA;
        totalScoreB += extraScoreB;
    }



    if (totalScoreA > totalScoreB)
    {
        cout << "Final Score is " << totalScoreA << " to " << teamA << " and " << totalScoreB << " to " << teamB;
        cout << endl;
        cout << teamA << " WINS!!!";
        cout << endl;
    }

    else
    {
        cout << "Final Score is " << totalScoreB << " to " << teamB << " and " << totalScoreA << " to " << teamA;
        cout<< endl;
        cout << teamB << " is the WINNER!!!";
        cout << endl;
    }

}

int teamScore(string teamName) {

    int score;
    int totalScore = 0;

    cout << "Enter the number of runs for " << teamName << " for all 9 innnings separated by space: ";

    for (int i = 1; i <= 9; i++)
    {

        cin >> score;

        totalScore += score;

    }

    return totalScore;
}


int extraInnings(string teamName) {

    int score;
    int totalScore = 0;

    cout << endl;
    cout << "Enter the number of runs for " << teamName << " for the 3 extra innings: ";
    

    for (int i = 1; i <= 3; i++)
    {

        cin >> score;

        totalScore += score;

    }

    return totalScore;
}