2 GOLD: A General Ontology for Linguistic Description GOLD, a General Ontology for Linguistic Description (http://www.linguistics-ontology.org/) (Farrar and Langendoen, 2003) is an OWL ontology that aims to capture ?the general knowledge of the field that is usually possessed by a well trained linguist.
N03-1020
W S J 8 80923 0163 DocumentIDs Un i g r a m  C o o cc u rre n c e  Sc o r e s B1 MaxH T CMPRH1 CMPRH2 CMPRH3 FT Linear(B1) Linear(MaxH) Linear(T) Linear(FT) Figure9.DUC2001singledocinter-human,baseline,andsystemunigramco-occurrencescoreversus compressionratio.DocumentIDsaresortedbyincreasingcompressionratioCMPRH1.  much.Theunigramco-occurrencescoresforB1,T,and MaxHwerenoisybuthad ageneraltrend(Linear B1, Linear T, and Linear MaxH) of drifting into lower performance when compression ratio increased (i.e. when summaries became shorter); while the performance of FT did not exhibit a similar trend. This confirms our earlier hypothesis that humans are less likely to agree at high compression ratio and system performancewillalsosufferathighcompressionratio. TheconstancyofFTacrossdifferentcompressionratios is reasonable since FT scores should only depend on how well the unigram co-occurrence scoring method capturescontentoverlapbetweenafulltextanditsreference summaries and how likely humans use vocabularyoutsidetheoriginaldocument. 6 Conclusions In this paper we presented an empirical study of the potential and limitations of sentence extraction as a method of automatic text summarization. We showed thefollowing: (1) Howtouseoracleextractstoestimatetheperformance upper bound of sentence extraction methodsatdifferentextractlengths.Weunderstandthatsummariesoptimizedusingunigram co-occurrence score do not guarantee good quality in terms of coherence, cohesion, and overallorganization.However,wewouldargue thatagoodsummarydoesrequiregoodcontent andwewillleavehowtomakethecontentcohesive, coherent, and organized to future research. (2) Inter-humanagreementvariedalotandthedifferencebetweenmaximumagreement(MaxH) and minimum agreement (MinH) was about 18%ontheDUC2001data.Tominimizethe gap,weneedtodefinethesummarizationtask better. This has been addressed by providing guided summarization tasks in DUC 2003 (DUC 2002). We guesstimate the gap should besmallerinDUC2003data. (3) State-of-the-artsystemsperformedatthesame levelasthebaselinesystembutwerestillabout 10% away from the average human performance. (4) The potential performance gains (15% from E100 to E150 and 24% to FT) estimated by oracleextractsofdifferentsizesindicatedthat sentence compression or sub-sentence extractionarepromisingfuturedirections. (5) Therelativeperformanceofhumansandoracle extracts at three inter-human agreement intervalsshowedthatitwasonlymeaningfultooptimize sentence extraction algorithms if interhuman agreement was high. Although overall highinter-humanagreementwaslowbutsubsets of high inter-human agreement did exist. For example, about human achieved at least 60% agreement in 59 out of 303 (~19%) documentsof30sentencesorless. (6) We also studied how compression ratio affectedinter-humanagreementandsystemperformance, and the results supported our hypothesis that humans tend to agree less at high compression ratio, and similar between humansandsystems.Howtotakeintoaccount thisfactorinfuturesummarizationevaluations isaninterestingtopictopursuefurther. Usingexhaustivesearchtoidentifyoracleextractionhas beenstudiedbyotherresearchersbutindifferentcontexts.Marcu(1999a)suggestedusingexhaustivesearch tocreatetrainingextractsfromabstracts.Donawayetal. (2000)usedexhaustivesearchtogenerateallthreesentencesextractstoevaluatedifferentevaluationmetrics. Themaindifferencebetweentheirworkandoursisthat we searched for extracts of a fixed number of words whiletheylookedforextractsofafixednumberofsentences. Inthefuture,wewouldliketoapplyasimilarmethodologytodifferenttextunits,forexample,sub-sentence unitssuchaselementarydiscourseunit(Marcu1999b). We wanttostudyhowtoconstrainthesummarization task to achieve higher inter-human agreement, train sentence extraction algorithms using oracle extracts at different compression sizes, and explore compression techniquestogobeyondsimplesentenceextraction. References Donaway, R.L., Drummey, K.W., and Mather, L.A. 2000. A Comparison of Rankings Produced by Summarization Evaluation Measures. In Proceeding oftheWorkshoponAutomaticSummarization,postconferenceworkshopofANLP-NAACL-2000,Seattle,WA,USA,6978. DUC.2002.TheDocumentUnderstandingConference. http://duc.nist.gov. Edmundson, H.P. 1969. New Methods in Automatic Abstracting.JournaloftheAssociationforComputingMachinery.16(2). Goldstein, J., M. Kantrowitz, V. Mittal, and J. Carbonell. 1999. Summarizing Text Documents: Sentence Selection and Evaluation Metrics. In Proceedingsofthe22ndInternationalACMConference on Research and Development in Information Retrieval(SIGIR-99),Berkeley,CA,USA,121128. Hovy,E.andC.-Y.Lin.1999.AutomaticTextSummarization in SUMMARIST. In I. Mani and M. Maybury (eds), Advances in Automatic Text Summarization,8194.MITPress. Kupiec,J.,J.Pederson,andF.Chen.1995.ATrainable Document Summarizer. In Proceedings of the 18th InternationalACMConferenceonResearchandDevelopmentinInformationRetrieval(SIGIR-95),Seattle,WA,USA,6873. Lin,C.-Y.and E.Hovy.2002. Manualand Automatic Evaluations of Summaries. In Proceedings of the Workshop on Automatic Summarization, postconference workshop of ACL-2002, pp. 45-51, Philadelphia,PA,2002. Lin,C.-Y.andE.H.Hovy.2003.AutomaticEvaluation of Summaries Using N-gram Co-occurrence Statistics. In Proceedings of the 2003 Human Language Technology Conference (HLT-NAACL 2003), Edmonton,Canada,May27June1,2003. Luhn,H.P.1969.TheAutomaticCreationofLiterature Abstracts. IBM Journal of Research and Development.2(2),1969. Marcu,D.1999a.Theautomaticconstructionoflargescale corpora for summarization research. Proceedings of the 22nd International ACM Conference on ResearchandDevelopmentinInformationRetrieval (SIGIR-99),Berkeley,CA,USA,137144. Marcu,D.1999b.Discoursetreesaregoodindicatorsof importanceintext.InI.ManiandM.Maybury(eds), Advances in Automatic Text Summarization, 123 136.MITPress. McKeown, K., R. Barzilay, D. Evans, V. Hatzivassiloglou, J. L. Klavans, A. Nenkova, C. Sable, B. Schiffman,S.Sigelman.2002.TrackingandSummarizingNewsonaDailyBasiswithColumbiasNewsblaster. In Proceedings of Human Language Technology Conference 2002 (HLT 2002). San Diego,CA,USA. NIST.2002.AutomaticEvaluationofMachineTranslationQualityusingN-gramCo-OccurrenceStatistics. Over, P. and W. Liggett. 2002. Introduction to DUC2002:anIntrinsicEvaluationofGenericNewsText Summarization Systems. In Proceedings of Workshop on Automatic Summarization (DUC 2002), Philadelphia,PA,USA. http://www-nlpir.nist.gov/projects/duc/pubs/ 2002slides/overview.02.pdf Papineni, K., S. Roukos, T. Ward, W.-J. Zhu. 2001. Bleu:aMethodforAutomaticEvaluationofMachine Translation. IBM Research Report RC22176 (W0109-022). Radev, D.R. and K.R. McKeown. 1998. Generating NaturalLanguageSummariesfromMultipleOn-line Sources.ComputationalLinguistics,24(3):469500. Strzalkowski,T,G.Stein,J.Wang,andB,Wise.ARobustPracticalTextSummarizer.1999.InI.Maniand M. Maybury (eds), Advances in Automatic Text Summarization,137154.MITPress. White, M., T. Korelsky, C. Cardie, V. Ng, D. Pierce, andK.Wagstaff.2001.MultidocumentSummarization via Information Extraction. In Proceedings of Human Language Technology Conference 2001 (HLT2001),SanDiego,CA,USA.
H01-1054 J98-3005 N03-1020 W00-0408
 ThePotentialandLimitationsofAutomatic SentenceExtractionforSummarization Chin-YewLinandEduardHovy UniversityofSouthernCalifornia/InformationSciencesInstitute 4676AdmiraltyWay MarinadelRey,CA90292,USA {cyl,hovy}@isi.edu   Abstract Inthispaperwepresentanempiricalstudyof thepotentialandlimitationofsentenceextraction in text summarization. Our results show that the single document generic summarizationtaskasdefinedinDUC2001needstobe carefullyrefocusedasreflectedinthelowinter-human agreement at 100-word 1 (0.40 score) and high upper bound at full text 2  (0.88) summaries. For 100-word summaries, theperformanceupperbound,0.65,achieved oracleextracts 3.Suchoracleextractsshowthe promise of sentence extraction algorithms; however, we first need to raise inter-human agreementtobeabletoachievethisperformance level. We show that compression is a promisingdirectionandthatthecompression ratioofsummariesaffectsaveragehumanand systemperformance. 1 Introduction Most automatic text summarization systems existing todayareextractionsystemsthatextractpartsoforiginal documents and output the results as summaries. Among them, sentence extraction is by far the most  1 Wecomputeunigramco-occurrencescoreofapairofmanual summaries, one as candidate summary and the other as reference. 2 Wecomputeunigramco-occurrencescoresofafulltextand itsmanualsummariesof100words.Thesescoresarethebest achievable using the unigram co-occurrence scoring metric sinceallpossiblewordsarecontainedinthefulltext.Three manualsummariesareused. 3 Oracle extracts are the best scoring extracts generated by exhaustive search of all possible sentence combinations of 1005words. popular (Edmundson 1969, Luhn 1969, Kupiec et al. 1995,Goldsteinetal.1999,HovyandLin1999).The majorityofsystemsparticipatinginthepastDocument Understanding Conference (DUC 2002), a large scale summarization evaluation effort sponsored by the US government, are extraction based. Although systems basedoninformationextraction(RadevandMcKeown 1998,Whiteetal.2001,McKeownetal.2002)anddiscourseanalysis(Marcu1999b,Strzalkowskietal.1999) alsoexist,wefocusourstudyonthepotentialandlimitationsofsentenceextractionsystemswiththehopethat ourresultswillfurtherprogressinmostoftheautomatic textsummarizationsystemsandevaluationsetup. TheevaluationresultsofthesingledocumentsummarizationtaskinDUC2001and2002(DUC2002,Paul& Liggett2002)indicatethatmostsystemsareasgoodas thebaselinelead-basedsystemandthathumansaresignificantlybetter,thoughnotbymuch.Thisleadstothe beliefthatlead-basedsummariesareasgoodaswecan get for single document summarization in the news genre, implying that the research community should investfutureeffortsinotherareas.Infact,averyshort summary of about 10 words (headline-like) task has replaced the single document 100-word summary task inDUC2003.Thegoalofthisstudyistorenewinterest in sentence extraction-based summarization and its evaluationby estimatingtheperformanceupperbound usingoracleextracts,andtohighlighttheimportanceof taking into account the compression ratio when we evaluateextractsorsummaries. Section 2 gives an overview of DUC relevant to this study.Section3introducesa recall-basedunigram cooccurrenceautomaticevaluationmetric.Section4presentstheexperimentaldesign.Section5showstheempirical results. Section 6 concludes this paper and discussesfuturedirections.  2 DocumentUnderstandingConference Fully automatic single-document summarization was one of two main tasks in the 2001 Document UnderstandingConference.Participantswererequiredtocreate a generic 100-word summary.There were 30 test setsinDUC2001andeachtestsetcontainedabout10 documents.Foreachdocument,onesummarywascreated manually as the ideal model summary at approximately 100 words.We will refer to this manual summary as H1. Two other manual summaries were alsocreatedataboutthatlength.Wewillrefertothese twoadditionalhumansummariesasH2  andH3.Inaddition,baselinesummarieswerecreatedautomaticallyby taking the first n sentences up to 100 words. We will referthisbaselineextractasB1. 3 UnigramCo-OccurrenceMetric Inarecentstudy(LinandHovy2003),weshowedthat therecall-basedunigramco-occurrenceautomaticscoringmetriccorrelatedhighlywithhumanevaluationand has high recall and precision in predicting statistical significanceofresultscomparingwithitshumancounterpart. The idea is to measure the content similarity betweenasystemextractandamanualsummaryusing simple n-gram overlap. A similar idea called IBM BLEU score has proved successful in automatic machinetranslationevaluation(Papinenietal.2001,NIST 2002).Forsummarization,wecanexpressthedegreeof contentoverlapintermsofn-grammatchesasthefollowingequation: )1( )( )( }{ }{       = UnitsModelCCgramn UnitsModelCCgramn match n gramnCount gramnCount C  Modelunitsaresegmentsof manual summaries.They are typically either sentences or elementary discourse unitsasdefinedbyMarcu(1999b).Count match (n-gram) is the maximum number of n-grams co-occurring in a systemextractandamodelunit.Count(n-gram)isthe number of n-grams in the model unit. Notice that the averagen-gramcoveragescore,C n,asshowninequation1,isarecall-basedmetric,sincethedenominatorof equation 1 is the sum total of the number of n-grams occurringinthemodelsummaryinsteadofthesystem summaryandonlyonemodelsummaryisusedforeach evaluation. In summary, the unigram co-occurrence statisticsweuseinthefollowingsectionsarebasedon thefollowingformula: )2(logexp),(         =  = j in nn CwjiNgram  Wherej i,iandjrangefrom1to4,andw n is1/(ji+1).Ngram(1,4)isaweightedvariablelengthn-gram match score similar to the IBM BLEU score; while Ngram(k,k),i.e.i=j=k,issimplytheaveragek-gram co-occurrencescoreC k .Inthisstudy,weseti=j=1, i.e.unigramco-occurrencescore. Withatestcollectionavailableandanautomaticscoring metric defined, we describe the experimental setup in thenextsection. 4 ExperimentalDesigns As stated in the introduction, we aim to find the performanceupperboundofasentenceextractionsystem andtheeffectofcompressionratioonitsperformance. We present our experimental designs to address these questionsinthefollowingsections. 4.1 Performance Upper Bound Estimation UsingOracleExtract Inordertoestimatethepotentialofsentenceextraction systems,itisimportanttoknowtheupperboundthatan ideal sentence extraction method might achieve and howfarthestate-of-the-artsystemsareawayfromthe bound. If the upper bound is close to state-of-the-art systems performance then we need to look for other summarizationmethodstoimproveperformance.Ifthe upper bound is much higher than any current systems canachieve,thenitisreasonabletoinvestmoreeffortin sentence extraction methods. The question is how to estimatetheperformanceupperbound.Oursolutionis tocastthisestimationproblemasanoptimizationproblem. We exhaustively generate all possible sentence combinationsthatsatisfygivenlengthconstraintsfora summary, for example, all the sentence combinations totaling 1005 words. We then compute the unigram co-occurrence score for each sentence combination, against the ideal. The best combinations are the ones withthehighestunigramco-occurrencescore.Wecall this sentence combination the oracle extract. Figure 1 showsanoracleextractfordocumentAP900424-0035. OneofitshumansummariesisshowninFigure2.The oracle extract covers almost all aspects of the human summaryexceptsentences5and6andpartofsentence 4.However,ifweallowtheautomaticextracttocontain morewords,forexample,150wordsshowninFigure3, the longeroracleextractthen covers everythinginthe humansummary.Thisindicatesthatlowercompression can boost system performance. The ultimate effect of compressioncanbecomputedusingthefulltextasthe oracleextract,sincethefulltextshouldcontaineverything included in the human summary. That situation provides the best achievable unigram co-occurrence score.Anearoptimalscorealsoconfirmsthevalidityof usingtheunigramco-occurrencescoringmethodasan automaticevaluationmethod.  4.2 Compression Ratio and Its Effect on System Performance Oneimportantfactorthat affectsthe averageperformance of sentence extraction system is the number of sentences contained in the original documents. This factorisoftenoverlookedandhasneverbeenaddressed systematically. For example, if a document contains onlyonesentencethenthisdocumentwillnotbeuseful indifferentiatingsummarizationsystemperformance there is only one choice. However, for a document of 100sentencesandassumingeachsentenceis20words long, there are C(100,5) = 75,287,520 different 100wordextracts.Thishugesearchspacelowersthechance of agreement between humans on what constitutes a good summary. It also makes system and human performance approach average since it is more likely to includesomegoodsentencesbutnotallofthem.EmpiricalresultsshowninSection5confirmthisandthat leadsustothequestionofhowtoconstructacorpusto evaluatesummarizationsystems.Wediscussthisissue intheconclusionsection. 4.3 Inter-HumanAgreementandItsEffecton SystemPerformance In this section we study how inter-human agreement affects system performance. Lin and Hovy (2002) reportedthat, comparedtoa manually createdideal,humansscoredabout0.40inaveragecoveragescoreand the best system scored about 0.35. According to these numbers,wemightassumethathumanscannotagreeto eachotheronwhatisimportantandthebestsystemis almostasgoodashumans.Ifthisistruethenestimating anupperboundusingoracleextractsismeaningless.No matterhowhightheestimatedupperboundsmaybe,we probablywouldneverbeabletoachievethatperformance due to lack of agreement between humans: the oracle approximating one human would fail miserably withanother.Thereforewesetupexperimentstoinvestigatethefollowing: 1. Whatisthedistributionofinter-humanagreement? Figure3.A150-wordoracleextractfordocumentAP900424-0035. Figure 2. A manual summary for document AP900424-0035. Figure1.A100-wordoracleextractfordocumentAP900424-0035. <DOC> <DOCNO>AP900424-0035</DOCNO> <DATE>04/24/90</DATE> <HEADLINE> <SHSNTNO="1">ElizabethTaylorinIntensiveCareUnit</S> <SHSNTNO="2">ByJEFFWILSON</S> <SHSNTNO="3">AssociatedPressWriter</S> <SHSNTNO="4">SANTAMONICA,Calif.(AP)</S> </HEADLINE> <TEXT> <SSNTNO="1">AseriouslyillElizabethTaylorbattledpneumoniaather hospital,herbreathingassistedbyaventilator,doctorssay.</S> <SSNTNO="2">HospitalofficialsdescribedherconditionlateMonday asstabilizingafteralungbiopsytodeterminethecauseofthepneumonia.</S> <SSNTNO="3">Analysisofthetissuesamplewasexpectedtotakeuntil Thursday,saidherspokeswoman,ChenSam.</S> <SSNTNO="9">Anotherspokewomanfortheactress,LisaDelFavaro, saidMissTaylor'sfamilywasatherbedside.</S> <SSNTNO="13">``Itisserious,buttheyarereallypleasedwithher progress.</S> <SSNTNO="22">Duringanearlyfatalboutwithpneumoniain1961, MissTaylorunderwentatracheotomy,anincisionintoherwindpipeto helpherbreathe.</S> </TEXT> </DOC> <DOC> <TEXT> <SSNTNO="1">ElizabethTaylorbattledpneumoniaatherhospital, assistedbyaventilator,doctorssay.</S> <SSNTNO="2">HospitalofficialsdescribedherconditionlateMonday asstabilizingafteralungbiopsytodeterminethecauseofthepneumonia.</S> <SSNTNO="3">AnalysisofthetissuesamplewasexpectedtobecompletebyThursday.</S> <SSNTNO="4">Ms.Sam,spokeswomansaid"itisserious,buttheyare reallypleasedwithherprogress.</S> <SSNTNO="5">She'snotwell.</S> <SSNTNO="6">She'snotonherdeathbedoranything.</S> <SSNTNO="7">Anotherspokeswoman,LisaDelFavaro,saidMiss Taylor'sfamilywasatherbedside.</S> <SSNTNO="8">Duringanearlyfatalboutwithpneumoniain1961,Miss Taylorunderwentatracheotomytohelpherbreathe.</S> </TEXT> </DOC> <DOC> <DOCNO>AP900424-0035</DOCNO> <DATE>04/24/90</DATE> <HEADLINE> <SHSNTNO="1">ElizabethTaylorinIntensiveCareUnit</S> <SHSNTNO="2">ByJEFFWILSON</S> <SHSNTNO="3">AssociatedPressWriter</S> <SHSNTNO="4">SANTAMONICA,Calif.(AP)</S> </HEADLINE> <TEXT> <SSNTNO="1">AseriouslyillElizabethTaylorbattledpneumoniaather hospital,herbreathingassistedbyaventilator,doctorssay.</S> <SSNTNO="2">HospitalofficialsdescribedherconditionlateMonday asstabilizingafteralungbiopsytodeterminethecauseofthepneumonia.</S> <SSNTNO="3">Analysisofthetissuesamplewasexpectedtotakeuntil Thursday,saidherspokeswoman,ChenSam.</S> <SSNTNO="4">The58-year-oldactress,whowonbest-actressOscars for``Butterfield8''and``Who'sAfraidofVirginiaWoolf,''hasbeen hospitalizedmorethantwoweeks.</S> <SSNTNO="8">Herconditionispresentlystabilizingandherphysicians arepleasedwithherprogress.''</S> <SSNTNO="9">Anotherspokewomanfortheactress,LisaDelFavaro, saidMissTaylor'sfamilywasatherbedside.</S> <SSNTNO="13">``Itisserious,buttheyarereallypleasedwithher progress.</S> <SSNTNO="14">She'snotwell.</S> <SSNTNO="15">She'snotonherdeathbedoranything,''Ms.Samsaid lateMonday.</S> <SSNTNO="22">Duringanearlyfatalboutwithpneumoniain1961, MissTaylorunderwentatracheotomy,anincisionintoherwindpipeto helpherbreathe.</S> </TEXT> </DOC>  2. Howdoesastate-of-the-artsystemdifferfrom averagehumanperformanceatdifferentinterhumanagreementlevels? We present our results in the next section using 303 newspaperarticlesfromtheDUC2001singledocument summarizationtask.Besidestheoriginaldocuments,we also have three human summaries, one lead summary (B1), and one automatic summary from one top performingsystem(T)foreachdocument. 5 Results In order to determine the empirical upper and lower bounds of inter-human agreement, we first ran crosshumanevaluationusingunigramco-occurrencescoring through six human summary pairs, i.e. (H1,H2), (H1,H3),(H2,H1),(H2,H3),(H3,H1),and(H3,H2).For a summary pair (X,Y), we used X as the model summaryandYasthesystemsummary.Figure4showsthe distributionsoffourdifferentscenarios.TheMaxHdistribution picks the best inter-human agreement scores foreachdocument,theMinHdistributiontheminimum one,theMedHdistributionthemedian,andthe AvgH distributiontheaverage.Theaverageofthebestinterhuman agreement and the average of average interhumanagreementdifferbyabout10percentinunigram co-occurrencescoreand18percentbetweenMaxHand MinH. These big differences might come from two sources. The first one is the limitation of the unigram 0 10 20 30 40 50 60 70 80 0.00 0.05 0.10 0.15 0.20 0.25 0.30 0.35 0.40 0.45 0.50 0.55 0.60 0.65 0.70 0.75 0.80 0.85 0.90 0.95 1.00 UnigramCo-occurrenceScores #  of  I n st an ce s AvgH MaxH MedH MinH AverageMAX=0.50 AverageAVG=0.40 AverageMED=0.39 AverageMIN=0.32 Figure 4. DUC 2001 single document interhuman unigram co-occurrence score distributions for maximum, minimum, average, and median. 0.00 0.10 0.20 0.30 0.40 0.50 0.60 0.70 0.80 0.90 1.00 D 4 1.
H01-1054 J98-3005 N03-1020
The automatic evaluation tool, ROUGE (Lin and Hovy, 2003), is run to evaluate the quality of the generated summaries (200 words in length).
N03-1020
Computational Linguistics 29.1 (2003): 19-51.
N03-1020
Cignoni, (eds.), Computational Linguistics in Pisa, Special Issue, XVIII-XIX, (2003).
N03-1020
The range of reports for any given patient at any given point in their illness thus present a special class of paraphrase, with a looser adherance to semantic equivalence between versions than is typically found in other paraphrase generators, for example Kozlowski et al (2003), McKeown et al (1994), Power, Scott and Bouyaad-Agha (2003), Rosner and Stede (1994),(1996), and Scott and Souza (1990).
N03-4008
