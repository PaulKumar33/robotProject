%low pass filter sim
function [trans, Q, zeta, wo, wc] = LowPassFilter(order, R, C, L, k)
    if(order == 2)
        if(R(1) == R(2) && C(1) == C(2))
            r = R(1);
            c = C(1);

            %define the ouput variables
            wo = 1/(r*c);
            wc = wo;
            Q = 1/(3-k);

            zeta = 1/(2*Q);
            
            %define the transfer function
            trans = tf([0 0 k], [1/(wo^2) 2*(zeta/wo) 1]);
            disp('Summary:')
            sprintf('Wo: %f', wo)
            sprintf('Q: %f', Q)
            sprint('Zeta: %f', zeta)
        end
    end

end