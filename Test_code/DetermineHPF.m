function [R, C, K] = DetermineHPF(Ri, Ci, wc, zeta, equal, order)
    %this function takes either a set of resistors or caps to determine values
    %for sallen key lpf topolgy
    if(Ri(1) ~= 0 && Ci(1) == 0)
        %for case when we want desired resistor value
        if(equal == 1)
            c = 1/(wc*Ri(1));
            C = zeros(1, order);
            R = zeros(1, order);
            for index = 1:order
                C(index) = c;
                R(index) = Ri(1);
            end            
            K = 3-(2*zeta);
        
        end
    end
    
    if(Ri(1) == 0 && Ci(1) ~= 0)
        if(equal == 1)
            r = 1/(wc*Ci(1));
            C = zeros(1, order);
            R = zeros(1, order);
            for index = 1:order
                C(index) = Ci(1);
                R(index) = r;
            end            
            K = 3-(2*zeta);
        end
    end
end
