Och (2003) developed a training procedure that incorporates various MT evaluation criteria in the training procedure of log-linear MT models.
P03-1021
Foster et al.(2002) developed a text-prediction system for translators that maximizes expected benefit to the translator under a statistical user model.
W02-1020
Another example of a loss function in this class is the MTeval metric introduced in Melamed et al.(2003). A loss function of this type depends only on information from word strings.
N03-2021
Bikel (Bikel and Chiang, 2000).
W00-1201
For all performance metrics, we show the 70% confidence interval with respect to the MAP baseline computed using bootstrap resampling (Press et al., 2002; Och, 2003).
P03-1021
In parsing, Goodman (1996) developed parsing algorithms that are appropriate for specific parsing metrics.
P96-1024
There has also been recent work that combines 1-best hypotheses from multiple translation systems (Bangalore et al., 2002); this approach uses string-edit distance to align the hypotheses and rescores the resulting lattice with a language model.
C02-1134
Translation lattices (Ueffing et al., 2002; Kumar and Byrne, 2003) are a compact representation of a large set of most likely translations generated by an MT system.
N03-1019 W02-1021
Examples of such loss functions are tree-edit distances between parse-trees, string-edit distances between event representation of parse-trees (Tang et al., 2002), and treekernels (Collins and Duffy, 2002).
P02-1016 P02-1034
Bayes-Risk Decoding Statistical Machine Translation (Brown et al., 1990) can be formulated as a mapping of a word sequence a0 in a source language to word sequence a1a3a2 in the target language that has a word-to-word alignmenta4a18a2 relative to a0 . Given the source sentence a0, the MT decoder a29 a8a25a0a21a13 produces a target word string a1a6a2 with word-to-word alignment a4a5a2 . Relative to a reference translation a1 with word alignment a4, the decoder performance is measured as a7a24a8a12a8a25a1a17a11a23a4a5a13a15a11a30a29 a8a25a0a21a13a12a13 . Our goal is to find the decoder that has the best performance over all translations.
J90-2002
We apply the Minimum Bayes-Risk (MBR) techniques developed for automatic speech recognition (Goel and Byrne, 2000) and bitext word alignment for statistical MT (Kumar and Byrne, 2002), to the problem of building automatic MT systems tuned for specific metrics.
W02-1019