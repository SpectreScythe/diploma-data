#include<iostream>
#include<stack>

int main(){
    std::stack <char> s;
    for(char c ='a' ; c <= 'f' ; c++){
        s.push(c);
    }
    while(!s.empty()){
        std::cout<<"Top element of stack \'"
        <<s.top()
        <<"\'"<<std::endl;
        s.pop();
    }
    std::cout<<"stack is empty!"<<std::endl;
}