1 SVM-based Chinese Word Segmenter We built out segmentation system following (Xue and Shen, 2003), regarding Chinese word segmentation as a problem of character-based tagging.
W03-1728
Templates We utilized four of the five basic feature templates suggested in (Low et aal., 2005), described as follows: • Cn(n = −2,−1,0,1,2) • CnCn+1(n = −2,−1,0,1) • Pu(C0) • T(C−2)T(C−1)T(C0)T(C1)T(C2) where C refers to a Chinese character.
I05-3025
Slightly different from (Low et aal., 2005), character set representing dates are expanded to include o � p  o p oM p oH p os p o � p, the Chinese characters for “day”, “month”, “year”, “hour”,“minute”,“second”, respectively.
I05-3025
Eric.Brill. 1995.
J95-4004
See detail description and the example in (Low et aal., 2005).
I05-3025
Partly inheriting from (Brill, 1995), we applied error-driven learning to filter prefixes in Sp and suffixes in Ss.
J95-4004
