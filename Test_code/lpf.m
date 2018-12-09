%transfer function for a sallen key lpf
c1 = 7.9577e-09;
c2 = 7.9577e-09;
r1 = 10e4;
r2 = 10e4;

wo = 1/(r1*c1);
%k is the gain condition
k = 1.586;
Q = 1;
%alpha = 2*(1/c1)*((1/r1)+1/r2));
if (c1 == c2 && r1 == r2)
    Q = 1/(3-k);
end


num = [k];
den = [1/(wo^2) 2*(Q/wo) 1];

sys = tf(num, den);