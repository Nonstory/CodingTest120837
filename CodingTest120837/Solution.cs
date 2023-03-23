//https://school.programmers.co.kr/learn/courses/30/lessons/120837

using System;

//1. 장군개미 공격력 : 5
//2. 병정개미 공격력 : 3
//3. 일개미   공격력 : 1

//정수 hp가 주어질때 최소한의 수로(넘쳐서는 안됩니다)
//적을 잡을 개미 병력의 수 구하기

//장군개미 > 병정개미 > 일개미 순으로 수가 많아야 유리하므로
// 5 3 1순으로 나누어서 몫과 나머지를 구해야합니다.
public class Solution
{
    public int solution(int hp)
    {
        int answer = 0;
        int generalAnt;
        int soldierAnt;
        int workerAnt;

        generalAnt = hp / 5; //정수끼리의 계산이므로 소수점이하는 버려집니다.
        hp = hp % 5;
        soldierAnt = hp / 3;
        hp = hp % 3;
        workerAnt = hp;

        answer = generalAnt + soldierAnt + workerAnt;

        return answer;
    }
}