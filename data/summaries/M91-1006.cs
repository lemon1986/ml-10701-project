The semantic interpreter uses structural rules, almost all created after 25 February 1991 . Nearly all of these carry over to all new domains . Domain-dependent, lexical semantic rules contain traditional cas e frame information . The novel aspect here is that the case frames for verbs were hypothesized by a statistical induction algorithm [Weischedel, et al., 1991a].
H91-1037
The experiments were concluded in March, 1991 and lead us to believe that statistical approaches can effectively improve knowledge-based approaches [Weischedel, et al., 1991a, Weischedel, Meteer, and Schwartz, 1991] . Due to nature of that effort, we had focussed on many well-defined algorithm experiments . We did not have a complete message processing system ; nor was the pilot study designed to create an applicatio n system.
H91-1037 H91-1065
Therefore, the combining algorithm was not thoroughly evaluated in MUC-3 . OFFICIAL RESULTS There are several alternative ways to run the algorithms, representing alternative degrees of conservative versu s aggressive hypothesis of templates and slot values . Two alternatives produced a noticeably different tradeof f between recall on the one hand, and precision and recall on the other . 1 We are now in process of integrating BBN's POST [Meteer, Schwartz, and Weischedel, 1991] probabilistic partof-speech tagger for the tagger in MITFP.
H91-1037 H91-1065
A more detailed description of th e system components, their individual outputs, and their knowledge bases is presented in a companion pape r [Weischedel, et al ., 1991b].
H91-1037
The discourse component performs three tasks: hypothesizing relevant events from the diverse descriptions, recognizing co-reference, and hypothesizing values for components of an event . The challenges faced by the discourse component are that syntactic relations present in the text and signifying the role of an entity in a hypothesized event are often not found by MITFP, and that reference resolution must be performed with limite d semantic understanding . Given these challenges, it is clear from the test results that the discourse component does reconstruct event structure well, in spite of missing syntactic and semantic relations . The template generator has three tasks : finding and/or merging events hypothesized by discourse processin g into a complete template structure, deciding whether to default the value of template slots not found in the even t structure (e.g, using date and location information in the header), and creating the required template forms . A critical component for future work is a fragment combining algorithm . Based on local syntactic and semanti c information, this algorithm combines fragments to provide more complete analyses of the input [Weischedel, et al ., 1991a].
H91-1037
This is detailed in [Weischedel, Meteer, Schwartz, 1991].
H91-1037 H91-1065
semantic interpreter finds a semantic analysis for the fragments produced by MITFP . Semantic analysis is shallow in that some analysis must be produced for each fragment even thought most of the words in an article hav e no representation in the domain model . (For instance, Jacobs et al.[1991] estimates that 75% of the words in these texts are not relevant).
H91-1066
