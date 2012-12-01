Our training set is a subset of the Canadian Hansards which consists of a35 a92 a8 a92a43a92a117a92 French-English sentence pairs (Och and Ney, 2000).
P00-1056
Furthermore, we restrict ourselves to the templates which have a probability a0a2a1a32a14a109a35 a21a22a28 a1 a92 a49 a92 a74 for some source phrase a21 . 4.2 Bitext Word Alignment We present results on the French-to-English Hansards translation task (Och and Ney, 2000).
P00-1056
We now introduce the word alignment variables a3 a49 a8a15a99a29a30 a74a48a8 a68 a8a130a49a52a49a51a49a52a8 a45, which indicates that a3 a49 is aligned to a26a5a4a7a6 within a9 and a21 . a0a2a1a34a9 a35 a14 a30 a1 a57 a53 a7 a8 a58 a55 a54 a8 a2 a28a41a8a10a21a22a28 a30 a53 a137 a49 a86 a7 a0a2a1a4a3 a49 a35 a14 a8a24a21a19a28a31a30 a53 a137 a49 a86 a7 a55 a8 a18 a86 a54 a0a2a1a4a3 a49 a8 a3 a49 a30a22a21a109a35 a14 a8a10a21a22a28 a30 a53 a137 a49 a86 a7 a55 a8 a18 a86 a54 a0a2a1a32a3 a49 a35 a3 a49 a30 a21a117a8a24a14 a8a10a21a22a28a96a0a2a1 a3a6a49 a30 a21a111a35 a2 a8a10a21a22a28 a30 a53 a137 a49 a86 a7 a55 a8 a18 a86 a54 a0a2a1a32a3 a49 a35 a26 a18 a28a96a0a2a1 a3a6a49 a30 a21a111a35 a2 a28a41a74a7a9a10a6a41a1a4a3 a49 a28a41a49 (16) The term a0a2a1a32a3 a49 a35 a26 a18 a28 is a translation dictionary (Och and Ney, 2000) and a0a2a1 a3 a49 a30 a21a48a8 a2 a28 is obtained as a0a2a1 a3a6a49 a30 a21a111a35 a2 a28 a30 a2a50a49 a18 a76 a18 a133 a2 a49 a18 a133 a49 (17) We have assumed that a0a2a1 a3a11a49 a35 a21a89a8 a2 a28 a30 a0a2a1 a3 a49 a35a2 a28, i.e. that given the template, word alignments do not depend on the source language phrase.
P00-1056
63-70 Proceedings of HLT-NAACL 2003 2 Alignment Template Translation Models We present here a derivation of the alignment template translation model (ATTM) (Och et al., 1999; Och, 2002) and give an implementation of the model using weighted finite state transducers (WFSTs).
W99-0604
The Alignment Template Translation Model (ATTM) (Och et al., 1999) has emerged as a promising modeling framework for statistical machine translation.
W99-0604
Our test set consists of 500 unseen French sentences from Hansards for which both reference translations and word alignments are available (Och and Ney, 2000).
P00-1056
and Translation Lattices The lattice of possible translations of a26 a27a7 is obtained using the weighted finite state composition: a6 a30 a23a25a112 a132 a122 a24 a122 a0 a122 a2 a122a8a7 a49 (22) The translation with the highest probability (Equation 20) can now be computed by obtaining the path with the highest score in a6 . In terms of AT&T FSM tools, this can be done as follows fsmbestpath a6 a35 fsmproject a15 a93 a35 a0 fsmrmepsilon a1 a110 a3 A translation lattice (Ueffing et al., 2002) can be generated by pruning a6 based on likelihoods or number of states.
W02-1021
Suppose a21 a0a4a3 a30 a26a6a5 a133 a5 and a21 a0a7a3a9a8 a105 a30 a26a11a10 a133 a10, we set the Markov chain probabilities as follows (Och et al., 1999) a0a2a1a32a18 a85 a35 a18 a85 a63 a7 a28a13a12 a87a15a14 a5a63 a10 a133 a63 a7 a14a54 a0a2a1a32a18 a7 a30a17a16 a28a79a30 a74 a23 a69 a16a38a71a25a73a19a74a117a8 a68 a8a130a49a52a49a51a49a51a8a24a23 a75 a49 (13) In the above equations, a87 a54 is a tuning factor and we normalize the probabilities a0a2a1a32a18 a85 a35 a18 a85 a63 a7 a28 so that a76 a11 a18 a86 a7 a107 a18a20a19 a86 a0a3a9a8 a105 a0a2a1a4a18 a85 a30a22a21a111a35 a18 a85 a63 a7 a28a31a30a129a74 . The finite state implementation of this model involves two acceptors.
W99-0604
The ATTM attempts to overcome the deficiencies of word-to-word translation models (Brown et al., 1993) through the use of phrasal translations.
J93-2003
Weighted Finite State Transducers for Statistical Machine Translation (SMT) have been proposed in the literature to implement word-to-word translation models (Knight and Al-Onaizan, 1998) or to perform translation in an application domain such as the call routing task (Bangalore and Ricardi, 2001).
N01-1018
We measured the alignment performance using precision, recall, and Alignment Error Rate (AER) metrics (Och and Ney, 2000).
P00-1056
