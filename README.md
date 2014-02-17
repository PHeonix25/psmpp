psmpp
=====

A .Net SMPP library with an easy separation of client and server, written with the latest parts of C#5 in mind.

	 ________________________________________________________________________________________________________________________________________________________________ 
	|W%8WKWAW8A8WWAW8AMKK%AA8MAA$KK$W#%$8Yz+)[XK,                      .-         .-,,-./cv\ii~c~///t7Y]j(Y+fc~v=/v_....,|!~\=cv||/|/))Y7f[Ygt7eTft+g+Lf4X4Gd5mdNZ**m|
	|M#MM8DbAAA88WMAKWKD8WW%KM8AM#WK8#AWWKPg/72YM                                  ..,-..|/vi\c_cv!!)Vz([[/)i_i==~=,,,..-,=\\!cv==!i\\_!Yzj()+)jjLg2LfTee*55dbd*Zb*mm|
	|WMWA%WmPNDNYWKAKAK*PMKM#MKAMMWWM%KKK$$WDZzg2K/                                .,--,.,,vv!\__=ic=\T(22Y]/_,./-,--,,-..,--.-c!=/\/|==/+tY)tTg2tTj2zTT(ggQdT(mY4***|
	|KAKAMKDd5b4DYm5KAddDM5dMAKK#AMA$8M##A$$#A5+=]W]                                ,--,,.-.-|/!\ii__i|\v\\!i-,..,,.,..--.-,..=__~cv|\/|~i/c|/fgz)TfL(fegV]g7z+b5GKN5|
	|MK888MKYbWMXAPGK8bPQd4dWAMK8WAA$K$$K#$%#KWML~_82                                ,-,,.--,-~i\i\\|\_!_/\v,.-,-,.,....-,,,-,i/~__==ci/!\!_c/!\v||f/(tj772T7[LKNZQZD|
	|K4AKAWN5MAK4KKDMW8WAAMDKAKQd8dAA%$#A#MKW%$%AY~|*/                                ----.-.--._/~v_v|=v//,--,,,.-.,,--,.-.,../ci,-_i_v=v=/|/|c=/cv~]T7)j(7Lj(ND*445|
	|MAWAA8b*mdG88WMKWPQAMW8DQKMmZ8dZKAM%KKAAAA%$bf]~e,                                ,-,.--....,|\!i~cc,,.,.,.-.,--.-.-,----,=--,.=_v||~=c\!~/=v_~_\/\(fj]TLGQbDYdY|
	|8KMW5M88K4KWMAK##KPmKdKKWA8W88AXd4GdWA%8WKK$#Q)/!/                                  .-,-.,-..-,\-..-..---.-,.--,.,.,,--,,.,-.-,,,!v\,i|vc!ci/==~/|_\/]j)Y5KY5DNX|
	|WANQKKKK$WAWWKKK8M8*()5P5A8MAAWMN74K8%WK8KW%A8YLt]!                                  ,..,-...,.-.-,,.,.-.-,--,,,-,.-,,..,,-,-,.,.,,--.--.,,i\!/||i_!z[L]PdGY55Z4|
	|KAAKWM8W8M8AG5KKPYW55bKb4)NAW*8MKjtMA8A#MAM#%$$8Nt/g.                                 ,..,....,-,-,,,..-.,,,,,,-.-,..,,,....,-,,..---,,..,--,,.v~/!|+(e+Xmb*NKmd|
	|A8KKWKM88WWAKNZ*Y7*5MWYMMtTgdeQ*mzmK)Y*DK$$$##K#K*DKX+                                  -..-..-..,,-,.,,-,.,,.,.,,-..--,,.,.,.-,,--.--,-...-,._!v~\=]V]zYVdGDYGZ|
	|88MAMA888QKMKZ5ZKA88NYYZGbTejYjLY//mZdK)NM$#%#%MM%$%%WG                                  -,.--.,----,-.,.|!..,.,-,,,,.,-...-,.--,,..,,,,-.,..-|=\v(2zVt(jjNQDdbm|
	|8M88AM8K8A8MWMWWWWAKDGAXV4bVT*M7Y/QAmK8X88WMM$K8##$%%##W.                                  -,,,-,,-,,-.,,v|..,,.,,.-...,---...--,-,--.-,--,,\icvi__~LfzYT)fg2(bd|
	|]ZQ8WMWAKWM8%MA8AKMMANKMG+(TL45meTXKKK8gbKdDDKKW$%W#$$M%#f                                   .-,,.,...-.,-.-.--.--.,,,----.,--.,,.-,,--,.c_~!_=c_\itL(TjzL)+(j72|
	|W8Zf/NQ888KKAWMMAKKMK8AM8Y_zYK5dKgPNKK8[*WAbDbPKKWM8WKAMA%(                                    -.-.--..,-.,,-..,--,----, ...---.,,----.\~_=!v/~|iv!)7YtY+z]t[+fg|
	|$##%Ab]]fNKKAKKAKKAWK5KA[jYdG5mPGGmAZ4KgXAG+bG88*5MKKM$W%AA*                                     ,,.,-,--,,,.,,.,..--,-,-..,,.,.-...,.=/~~/!!i/vcviiTVV2+z7Vt7X*|
	|#%#$###8Amg(DYAAKKWMAAAM4D8XdMKbM44MMK*d/TVKM4MAD+ZYPPd8K8K%Ki                                     .---.---.,..-.----..,,.-,,.--.-,-/\/_|-,..,==/\c/([7Y7jz4DbdG|
	|###%#$##$#%KXejV5KAAMMMWKK8ZK8PMM5K+gZ4WMNdKYZm5Xd8P5Y])PMKM8%z                                       .--.--,-...-.---..-,.,-.-..,i~\\c~..,,.._//!c)Lz++g]TZ4*4D|
	|%%#$%$$##8$###KKNT2+*4A8M8KWMKmWMj)](L2Y44m5[YX+LGNQYmNV4A8AWK%K                                        ---..,,-,---    ,-,,,.,..,-,-.---.,-//i=c~|/\\t]/j)V/d4Y|
	|#%%$$%##$$%$MK$#$$Ab4)VVmZAKA8AAA8mZbQz])[QV_[Ntg4XfjNeeNdd8MMK$K,                                        ,.,,-,,          -,.--.-,,,..-\|/=ivc~\ic//|_TVz(+j]e]|
	|$%%%%%#$%%##$$%MKK%#%WMNf[VXNKKWWKAMK8DZY5Pe+TVjzDZ[jf+/+4)7ZWMMM#[                                         -,-,          -,.-..,,-..,,,,,,,-,,,.||\v~ci_~|/L+j[|
	|#%%$$%%%%%%#%##$%%$MKW$#$KWbg+tYGb8WKKMM8ZPX]YXtT]dQf]NVtbQNz2NXKK$W                                                        -,.-.,-!=_.--.,,.--,,-,.=/_|/=!|=|/!|
	|###%##%###$$###%$#%$$#K8A$%$$8Y)Ve/YQMAWWKAMdb8Y5(VL]+K)[j+QK+e/dAM%A,                                                      .-...._vc,,.--,.,..,-,..,,..-,..-,.,|
	|#$%$%%#%$$%###$%##AK$$$%#AM8M#$$WMYjefLNYAKWAKdX)Dt)czY[*j)/d+eLL(mAA$V                                                     -.,-,,-,..--,-.-.,----.,-,,--,,,,-.,|
	|%%%$%MAKM8$AW8%#%%%A%$$MWWWMA8888#$%8b4j7[bXZKMAKdK2TYe]4V[7t*f/gT7Y5K%]                                                      ,,,,-..----.,-.-,.--,--,,,.-.-....|
	|$%#%#AA$M8AA88W88MA8MAA8KKMMMKWAWKWK8%$WMbj+j2ZPKAM8b55jK]fzVV\_vKt]75WW8,                                                     -.-..-,,,---,--,,..,--,,--,.,..,.|
	|#%%###8%AK88AAKK88AMW8AAAMKKK8M8K8MMA8AM8$K8Zd[t(Q4WAK8XN7ztYY2=Yj=~LYtXKW                                                      ,.-,,-,-,,..,.,.-.-,,-,,,-.-..--|
	|%#%$%#AMW8M88WAMKKKWWK8MMK8WM8KAMKMAKWAK8WW8WMAAN()L[XmAAYK7(ftVL)|Qef[vZ%b                                                      -,-,.---,.   .,.---,,..---,.,-.|
	|#$#%$%$#AKMWKMKWMKKMMMAKW8MAKWKKKKKWAMMA8KKMWMAWWW845]Tj7Xm8KtLvz[T2Y77!vb8v                                                    ,,,...,             ,.,,--,...,-|
	|#%$#8W%WAWWAWWW8AK88WMW8WKWW888MMM8MKAWMWKWKWM88W8888K8*7T()*ZY5T_v~=\=gvc7MAd                                                     --,.,.,           ,,--,..,-.,|
	|$%A##AWAMMWAAAAAWMKAKK8W8K8KKKAW8WW88KMK8K88A8W8AWAW888AMM4ZL)[[G5*NVi|T~~i/tAD                                                                         ,----,..|
	|KM#WWKWKWM8KA888M8K8A88MMM88KM88WAMKWM8WMMWKA8WW88MKMWAA8AM8MWmD(z]m4Zgt~,viv_PK                                                                         --..-.-|
	|%$88#%$WAMMWAA8WWAWK8KAMKAMKKK8KMKM8WKA8WWAAMKKWWMWWAAMAWMKAWKKWNGY/jjdZYY~|=,.GK-                                                                              |
	|%$$$$%$$8##KK8WMAAWKKAWAAKAWWM8MAMWK8MKMAAM8888KKMKAWMWWDd5Y4KNXX5Q4m*fz7bmz=~!i[A,                                                                             |
	|%#$#$%%#%$####K88MWKWA8AM8M8KMKAAM8MM8AAM8KMKAKKWK8AM8AMGNK*NQdZZQQKPX4NdQ][Y[g_,-D-                                                                            |
	|$$$%%##%#%#%#$#$W#K8%KMK88AAAM8MMAMWAA8M8WKAA8WMWA8AKAMMWMW4N4mD54mDP5dKNQPGQ]72T=v~                                                                            |
	|%%$#####%$%%$$#$%#%%%%%$AAWKKMKW8M88WAKWAKMKWM8AAWMAWMMMWAKWM8ddGPmPXQ4*QP4XNK*+jfe=                                                                            |
	|%$##$%$##$#%%%%#$#%%%%%$%88AKWWWAM8WK8AKAAAWAWKKAMMKKKMKKKMA88KPPQZ*5*dNQN*PXYGQK)zL.                                                                           |
	|$#%###$##%%$%%%%$$%%%$$##AMWA8M8W88KMM88W88KMM8MMMMKWMWAW8KKAMZXmmQmQXZ*4*Q5PQdPQX*2T!                                                                          |
	|%%$$%##%%$##%%%#%$%%#$$$%$WWKMAKM8KAA8MWMA8AWWW8AWAAM8A8MM8KKKWPD*mKPm*GPZDPGPbQjtjfeeL.                                                             ,,,.--     |
	|#$#####%$$%$$%$%#%#$%$##$$AAKAAKAAWAWAW8KMAWM8KMMKAW8AKKKA88AKWWP5GZQ5PXKPXNQ55P~TzKYPQ4]                                                             ,--.,-...,|
	|%$$$#$##%%##$$#$#%#$#%$%##WAMKKAWKKAKWA88A88WK8MAMK8KKKMM8W8KA8MWMK8MMZ2fv,,]4*5QmPD5GKNbj                                                            ,-,.,-...,|
	|##$%#$#$#%$#$%%#%$$%$###%$#%A%MMAMAAK8WWW8MAK8MMAMMAMMMWA8AAAWKK8KK+/,-.\jQd**XdmbPK*5Ym+2t|                                                             ,,-,,,.|
	|$$%#%$##$##$$%%#%##$##$%$$$M$WWA8AAM8WWWWAWAKKAM8MAMMA8KMAKAMNt=.. -\(PMKMZK5QmPd44dPdD5*ze\-                                                                -.,|
	|##$%$#$$%%$##$####%%$##$%$$$%#KWM8MWWAWAWKKWMAW8W8AAMKKM8X+\   -vGdMW8MbKKZ5b5dm4mbXXmdKdQY|~. ,                                                                |
	|#%##$%###$$#$$%#$###%##$$$$##AWA8M8MMWAKWAWWWMKK##8WKj/,   .TZW8MK8W*5Qm5*dQYZ4ZN**5DPPXYKT~7. -i                                                               |
	|#%%$#$%##$$#%$##$$%%$#%$$$%#%$MM8KAWMKAWWKW8%$A57\.,   |j*KAMAKMAA8WAAAKDZZZZm*DbPZ*D4YbDDPc7!, v\~,                                                            |
	|###$%####%%#$%%#%%#$%%#%####%#K%KMKMKMM8A8M$D,    .v+GMAKMAKKMWKKAW8M8K88QbZGm4QGKP5ZYN45Qbiz~. ,-|[]                                                           |
	|$%#%#$$#%%#%%##%$$##$%$%$###$%MA88AM88KMKWKAY- \48W%%KAMW8MM8KW8KKMAMKKW8AMDZb*d4bYdGNb4PdQ!z7\-,-.-.|=                                                         |
	|$##$$##$#%####%$#$###%#%###$$$#MM8AK8KW8W8WA%#%##M8WMWWWKAW8KKKWW8MW8WWM8WAGXDm55XN4GDNbYQDg|2cz.-,,,,c_                                                        |
	|###%%%#$$%$%%%$$$#$$##%$%#$$$##K$8$KAAA8KKMWW88W8KAMMM8KWMM8WWA8MKWKAAW8A8KPDdKKbKm5YGQPNQZT_X!v.,.,-v.,i                                                       |
	|##%$$%#####$$$%##$%#$###%$$W#%8M%##AM8KMKMK8M8WWAMAK8K8WM88MW8K8K8KKAKAMMKK4YdXDPZQQZNNmbG*N-Q[\_!,.-.,_-v\                                                     |
	|#%$%$$$$##%$%%%%%$##%%%$A8KW$#$%K#$MM88WAKKA8W8AAMKMAWWMW888KAMAK88AMMWA8WKdPXXYbGN5NYmGKmX*~+t|t_/,,,c!.v)!.                                                   |
	|#%#%#%$$#$%#$$%%%%#%#%$%##$$%#$$#$$AWW8KWAMAMWK8M88MKMW8KA8AW8WKWKWKWAM8WMMdKDDY544KmGmXm4dZivZi-c--./._i-/i!v                                                  |
	|###%$%#%$#%$#$##%%##%$%%#$#W#%#$%$%$AMAM8WKWWM8MAW88MKWKA8MMM8AA8W8M8MMM88WGNdddZ*GMK4dYD4KGj.bf==~.,.-/=-.,v\!,                                                |
	|$#$%$$$$%$#%#%$$#%##$%%$##%%###$$#$$KM88WAWWK8AWKKWWMMAMWMM8KMKMWWWMWMMWMM*GMAmbdKW8QNDNDmbDb-Dbc2!---,,(==-\_\v\,                                              |
	|$#%$#%#%$%$%#$$%$###%%$##%$#%#$8#$##%$$MKKWAMMMW8KAKKAWKMMKAAMWK8MWKMWMKAWKKA8AD8W8MWQ5NKZ44Q.eZV_~~.---j7_|vv\c!_~-                                            |
	|%#$###$#%$#%$%$$#%%%$%%%$$#$$%%###$#%%%%KMW8A8K88MW8WAWM8MWAWAMAMMMKWAMW8KW8M8MMMW88KG4bNG5m8-=KNv!~..i,,7).--/|ci\!\c                                          |
	|$#%##%#$%$##$%#%$#%$#$%%$$#%#%$###%#%%$#MAMMAKWAAWKKKAKAKAAKMWKW8KKKAKW8KM88KWMWMAWAMQDNbYPGK~\GNz-_c-c.-\7/~c-=t!|~vv_                                         |
	|%#%$##%##$$$%%%%%$##$##%%$#$#%$%%$#%$##8$MKKA88AWKWWKWAKMM8KKMMWAWAM8MKWKW8AA8MKAW8MAWYNZN4m8g,PGQi!=\--,.ctcvvc(Ze\v_!\                                        |
	|###%$#%%$$$%%$#%$%%$$%##%%%##%%#%#%####%A88AWAKAK8M8AKMWMMAMA88KMKWWKMAAK88KAWWAAMAWWAMN*DdXGb.4ZK)c\_..-,\2=c/(=jmj=c~!~\,                                     |
	|%%##$%%$$%######%$$##%$#%%#%$$$%%$#$#$#%$8KMKKMKAW8AKKAK88A8WK8WKAMW8WWMKAMA8WMKAKWMAMAKAN4Xm8.[4KX-i,ci--c~+/c=jcTQXj_/vi+~,                                   |
	|%$$%#$$%#$#%$%%#%$$##%$%%$#%%%$$$$$$#$$#$##KWWKMK8KAKA8MKW8KKM8MAK8W8AMW8WMK8WKM8WW88WWKAAYKbK~/DPK/c-.v!.i=/=_!ig=YXNG[!cj]/!                                  |
	|%#$##%$#%$#%##$#$$##$$%$%%$%$$$%%##%%%#%$%$%AK8%8#88WK8KWA88AM8AKMAMAWKAW8MAMWKAKMW88KWKMWAKXMt,dQK)iv.|[i-cV/.2jvv=YTdbgvc[TVV/,                               |
	|#$%%$#$$%##$%%%$%$##%$%$$#$%###$$$#%%#$$8$$#%$%$%$%WM8MK8AK8AWKA8WW8MKK888M8KWMKKAWMM8WAKWKWAKY QKW4vi.._t,,|V*e/VVt!g]bN)V|7+zz]T/                             |
	|%#$%$$%%%%#$$%#$$$%#%$$$%$$%#%%#$$%%#$###%###%%%$$%%#8KAKMMKWAWMAMAAWMWKMKKKMKMW88MKM88WA8KWMAD 4ZXW/!=v!g|,-7G(!2j[/2VmDm4]ij7Vjgt)-                           |
	|$%$$%%%$$%#%%#$##%%%%%##$$$##$#$#%$#$$$#%%%$##$$$%##$##WWWA8WWWWMKAW8AKWMM8AAWWAAWKAMKAK8AWW88A-]8*8Q~,!!L(\-\jb_,fV!itVMXYVf()jLt]]2/                          |
	|%#%$%$#%%$%%$#%$$%$#%$#%$#%%$%#%###%$%%$%%%%####$$###MM8KWWWWWKKK8KM88MWKKKAAAWWMWK8KAMWMMKWWWM!,ADKA)cLecg=,-|tzcv!|!Y/NKzD*g7++gegL/7i                        |
	|##$%#%$$##$#%%$%##%$#$$%#$#%%$$#$$$%#$%$#%#%%###%#$$$KK8W88KA8M8AKAMMKKK8W8WAWWWWW8AMA8W88WAM8W7 8QAW*/fe[c/!.!e]+_,t*V]TNN(PYtee/2jT+/QV,                  PH  |
	|$#$%#$%$#%%##%%%%$#$#$#%%$#$#$##$#$$%%$#%$%#####%###WKKKMKA888WAWM8AAWWKWWWKMM8KKM88KAMAKKAAAKMG b4d8Xi_2)~v_.=/V]Y2cfv)zzKY)ddX4TV/TV2P4fg-____________________| 