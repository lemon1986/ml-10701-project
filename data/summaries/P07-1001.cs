We also compare with results of IBM Model-4 word alignments implemented in GIZA++ toolkit (Och and Ney, 2003).
J03-1002
We simply modify the GIZA++ toolkit (Och and Ney, 2003) by always weighting lexicon probabilities with soft constraints during iterative model training, and obtain 0.7% TER reduction on both sets and 0.4% BLEU improvement on the test set.
J03-1002
These feature weights are tuned on the dev set to achieve optimaltranslationperformanceusingdownhillsimplex method (Och and Ney, 2002).
P02-1038
It has been shown that human knowledge, in the form of a small amount of manually annotated parallel data to be used to seed or guide model training, can significantly improve word alignment F-measure and translation performance (Ittycheriah and Roukos, 2005; Fraser and Marcu, 2006).
H05-1012 P06-1097
Melamed. 2000.
J00-2004
Discriminative word alignment models, such as Ittycheriah and Roukos (2005); Moore (2005); Blunsom and Cohn (2006), have received great amount of study recently.
H05-1011 H05-1012 P06-1009
Toutanova et al.(2002) augmented bilingual sentence pairs with part-of-speech tags as linguistic constraints for HMM-based word alignments.
W02-1012
Basic models in two translation directions are trained simultaneously where statistics of two directions are shared to learn symmetric translation lexicon and word alignments with high precision motivated by (Zens et al., 2004) and (Liang et al., 2006).
C04-1006 N06-1014
For instance, the most relaxed IBM Model-1, which assumes that any source word can be generated by any target word equally regardless of distance, can be improved by demanding a Markov process of alignments as in HMM-based models (Vogel et al., 1996), or implementing a distribution of number of target words linked to a source word as in IBM fertility-based models (Brown et al., 1993).
C96-2141 J93-2003
By combining word alignments in two directions using heuristics (Och and Ney, 2003), a single set of static word alignments is then formed.
J03-1002
Moore. 2005.
H05-1011
Results Our baseline word alignment model is the word-toword Hidden Markov Model (Vogel et al., 1996).
C96-2141
Work Heuristics based on co-occurrence analysis, such as point-wise mutual information or Dice coefficients, have been shown to be indicative for word alignments (Zhang and Vogel, 2005; Melamed, 2000).
J00-2004 W05-0829
The language model is a statistical trigram model estimated with Modified Kneser-Ney smoothing (Chen and Goodman, 1996) using all English sentences in the parallel training data.
P96-1041
We shall take HMM-based word alignment model (Vogel et al., 1996) as an example and follow the notation of (Brown et al., 1993).
C96-2141 J93-2003
We measure translation performance by the BLEU score (Papineni et al., 2002) and Translation Error Rate (TER) (Snover et al., 2006) with one reference for each hypothesis.
P02-1040
Our decoder is a phrase-based multi-stack imple5 mentation of the log-linear model similar to Pharaoh (Koehn et al., 2003).
N03-1017
As formulated in the competitive linking algorithm (Melamed, 2000), the problem of word alignment can be regarded as a process of word linkage disambiguation, that is, choosing correct associations among all competing hypothesis.
J00-2004
While word alignments can help identifying semantic relations (van der Plas and Tiedemann, 2006), we proceed in the reverse direction.
P06-2111
It can be applied to complicated models such IBM Model-4 (Brown et al., 1993).
J93-2003
