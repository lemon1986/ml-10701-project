To reduce such errors, Ng and Cardie (2002a) and Ng (2004) use an anaphoricity classifier –which has the sole task of saying whether or not any antecedents should be identified for each mention– as a filter for their coreference system.
C02-1139 P02-1014 P04-1020
This feature set is similar (though not equivalent) to that used by Ng and Cardie (2002a).
C02-1139 P02-1014
Also, we minimize rather than maximize due to the fact we transform the model probabilities with −log (like Roth and Yih (2004)).
W04-2401
Previous work on coreference using maximum entropy includes (Kehler, 1997; Morton, 1999; Morton, 2000).
P00-1023 W97-0319 W99-0212
Ng and Cardie (2002a) suggest overcoming such failings by augmenting their coreference classifier with an anaphoricity classifier which acts as a filter during model usage.
C02-1139 P02-1014
Another option is to pick the antecedent with the best overall probability (Ng and Cardie, 2002b).
C02-1139 P02-1014
5.2 JOINT-ILP: joint anaphoricity-coreference formulation Roth and Yih (2004) use ILP to deal with the joint inference problem of named entity and relation identification.
W04-2401
Our problem formulation and use of ILP are based on both (Roth and Yih, 2004) and (Barzilay and Lapata, 2006).
N06-1046 W04-2401
Following common practice, results are given in terms of recall and precision according to the standard model-theoretic metric (Vilain et al., 1995).
M95-1005
In future work, we will explore the use of global constraints, similar to those used by (Barzilay and Lapata, 2006) to improve both precision and recall.
N06-1046
This requires careful determination of an anaphoricity threshold in order to not remove too many mentions from consideration (Ng, 2004).
P04-1020
Most work treats coreference resolution as a binary classification task in which each decision is made in a pairwise fashion, independently of the others (McCarthy and Lehnert, 1995; Soon et al., 2001; Ng and Cardie, 2002b; Morton, 2000; Kehler et al., 2004).
C02-1139 J01-4004 N04-1037 P00-1023 P02-1014 P04-1020
The source of this variance is likely due to the fact that we applied a uniform anaphoricity threshold of .5 across all datasets; Ng (2004) optimizes this threshold for each of the datasets: .3 for BNEWS and NWIRE and .35 for NPAPER.
P04-1020
In generating the training data, we followed the method of (Soon et al., 2001) creating for each anaphor: (i) a positive instance for the pair 〈i,j〉 where i is the closest antecedent for j, and (ii) a negative instance for each pair 〈i,k〉 where k intervenes between i and j.
J01-4004
Ng (2004) obtains f-score improvements of 2.8-4.5% by tuning the anaphoricity threshold on held-out data.
P04-1020
Luo et al.(2004) use Bell trees to represent the search space of the coreference resolution problem (where each leaf is possible partition).
P04-1018
Model parameters are estimated using maximum entropy (Berger et al., 1996).
J96-1002
5.1 COREF-ILP: coreference-only formulation Barzilay and Lapata (2006) use ILP for the problem of aggregation in natural language generation: clustering sets of propositions together to create more concise texts.
N06-1046
A third global approach is offered by Ng (2005), who proposes a global reranking over partitions generated by different coreference systems.
P05-1020
Recent work has examined such models; Luo et al.(2004) using Bell trees, and McCallum and Wellner (2004) using conditional random fields, and Ng (2005) using rerankers.
P04-1018 P05-1020
Specifically, we estimate parameters with the limited memory variable metric algorithm implemented in the Toolkit for Advanced Discriminative Modeling1 (Malouf, 2002).
W02-2018
These different coreference systems are obtained as combinations over three different learners (C4.5, Ripper, and Maxent), three sampling methods, two feature sets (Soon et al., 2001; Ng and Cardie, 2002b), and three clustering algorithms (Best-First, Closest-First, and aggressivemerge).
C02-1139 J01-4004 P02-1014
This score is slightly lower than the scores reported by Ng and Cardie (2002a) for another data set (MUC).
C02-1139 P02-1014
