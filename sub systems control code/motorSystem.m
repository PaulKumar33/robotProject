%system analysis of dc motor

%system parameters
J = 0.01;
b = 0.1;
K = 0.01;
R = 1;
L = 0.5;
s = tf('s');
motor = K/((J*s+b)*(L*s+R)+K^2);
linearSystemAnalyzer('step', motor, 0:0.1:5);

%analyzing the parameters
p = tf(zeros(1,1,10));
for i = 1:10
    p(:,:,i) = K/((J*s+b)*((L+i/10)*s+R)+K^2);
end
linearSystemAnalyzer('step', p, 0:0.1:5)