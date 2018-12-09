%determine parameters
function [R, C, K] = DetermineLPF(r1, r2, c1, c2, ra, rb, wc, Q, equal)
    if(equal == 1)
        r1 = r2;
        c1 = c2;
        if(ra == 0 && rb == 0)
            K = 1;
        else
            K = 1+(ra/rb);
        end
        R = [0 0];
        C = [0 0];
        if(r1 ~= 0 && c1 == 0)
            %finding c
            %wc = 1/rc
            c = 1/(wc*r1);
            C = [c c];
            R = [r1 r1];
        end
        
        if(r1 == 0 && c1 ~= 0)
            r = 1/(wc*c);
            R = [r r];
            C = [c1 c1];
        end  
        disp(R)
        disp('++++++++++')
        disp(C)
    end
end