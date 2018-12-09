t = 0:0.00005:10;

Vin = 0.1*sin((2000*pi)*t);
Vneg = 0;
Vref = 0;

Rg = 5000;
vout = (Vin - Vneg)*(5+200000/Rg)+Vref;

Rg = 1000:1000:100000;
gain = (5+200000./Rg);
gain_log = 20*log10(gain);