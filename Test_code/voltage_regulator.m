%this script is a simple voltage regulator spec script

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%voltage regulator circuit for increasing voltage output
r1 = 10000;                                                                  %this is held constant
r2 = linspace(0, 10000, 11);                                                %variable resistor to adjust output
vxx = 12;
id = 0.006;
vout = 12*(1+(r2/r1))+id*r2;

figure(1)
xlabel('r2 resistance')
ylabel('output voltage')
title('Resulting voltage of system')
plot(r2, vout)
hold on

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

%this block is to simulate when r1 is variable instead
r2 = 10000;                                                                  %this is held constant
r1 = linspace(0, 10000, 11);                                                %variable resistor to adjust output
vxx = 12;
id = 0.006;
vout = 12*(1+(r2./r1))+id*r2;

figure(1)
xlabel('r2 resistance')
ylabel('output voltage')
title('Resulting voltage of system')

plot(r1, vout)

legend('r2 is variable', 'r1 is variable')
