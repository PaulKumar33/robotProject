function [wc] = HPFcutoff(R, C, equal, order)
    if(order == 2)
        if(equal == 1)
            r = R(1);
            c = C(1);
            
            wc = 1/(r*c);
            disp(wc/(2*pi))
        end
    end

end