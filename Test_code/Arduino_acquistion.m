%this code is used to interface with arduino and matlab
clear 
clc

%change these for which ever test is being done
a = arduino('Com4');            %defines arduino com port
plt_title = 'Data log';
xLabel = 'Time [s]';
yLabel = 'Voltage [V]';
legend = 'EMG Data';
yMax = 100;
yMin = 0;

delay = 0.01;

%measuremnt variables
time = 0;
voltage_read = 0;
count = 0;

%plot
plot_fig = plot(time, voltage_read, '-b');
title(plt_title);
xlabel(xLabel);
ylabel(yLabel);
axis([yMin yMax 0 100]);
grid('on');

tic

while ishandle(plot_fig)
    %writePWMVoltage(a, 'D11', (5/20)*i);
    a_data = readVoltage(a, 'A0');
    count = count + 1;
    time(count) = toc;
    data(count) = a_data;    
    set(plot_fig, 'XData', time, 'YData', data);
    axis([0 time(count) 0 5]);
    %pause(1/(2*1000)); 
end

delete(a)
disp('Plot closed');




