﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//nom: kim-pahud
//date: 2023-11-05
//description: mon premier jeu

namespace ProjetNarratif
{
    internal class Program
    {


        static void Main(string[] args)
        {
        //futur ajout de différents mode de difficultée pour les QTE
        //idées options pour la forêt: corps, corde, pieux, clairière.
        //idées de succès: - suicide réussi(se suicider, pas tué femme et enfant, dire aurevoir à la famille et laisser une note aux enfants ?? ne pas tué de collègues ou ne pas aller au travail??)
        //                 - mort avec classe(se suicider, prendre un bain et se raser)
        //                 - suicide raté(se suicider, ne pas dire aurevoir, ne pas laisser de note)
        //                 - la survie à quel prix?(ne pas se suicider)
        //                 - la fin?(se suicider)
        //                 - famille(découvrez le nom de toute votre famille)
        //                 - merci d'avoir joué(faire toutes les fins au moins une fois)
        //                 - surhomme(avoir réussi le QTE final et sauver votre famille)
        //fin rentrer maison manger femme et enfants
        //fin forêt aller suicide
        //fin forêt retour suicide ? + collègues tués?
        //si prendre repas midi dans la cuisine faim contenu à midi et collègue sauvé sinon assouvir faim avec collègue
        messdébut:;
            string messdébut = " ";
            Console.WriteLine("ATTENTION");
            Console.ReadKey();
            Console.WriteLine("ce jeu parle de sujets sensibles tel que la dépression et le suicide.");
            Console.ReadKey();
            Console.WriteLine("si vous n'etes pas à l'aise avec de tels sujets veuillez [quitter] l'application.");
            Console.ReadKey();
            Console.WriteLine("sinon vous êtes libre de [continuer].\n");
            Console.Write("choix : ");
            messdébut = Convert.ToString(Console.ReadLine());
            if (messdébut == "continuer")
            {
                goto continuer;
            }
            if (messdébut == "quitter")
            {
                goto fin;
            }
            else
            {
                Console.WriteLine("\ndésoler ce n'est pas une option\n");
                Console.ReadKey();
                goto messdébut;
            }


        continuer:;
            // déclarer les bool des succès ici pour qu'ils soyent sauvegardés entre les parties

            //FINS
            int nbdefintotale = 1;//******************** modifier à chaque fin rajoutées ****************************************************
            int nbdefindécouvertes = 0;
            bool finpont = false;

            //SUCCÈS
            int nbdetropdécouverts = 0;
            int nbdetroptotale = 3;
            bool âme_sensible = false;
            bool nostalgie = false;
            bool repas_mignon = false;
            bool mort_avec_classe = false;

            //gore activé ou pas
            bool gore = true;
        messgore:;
            string choixgore = " ";
            Console.WriteLine("ce jeu contient des descriptions gore qui peuvent s'avérer choquantes pour un certain public.");
            Console.ReadKey();
            Console.WriteLine("si vous souhaitez désactiver le gore dans les descriptions entrez [non]");
            Console.WriteLine("si vous êtes à l'aise avec ce genre  de description entrez [oui]\n");
            choixgore = Convert.ToString(Console.ReadLine());
            if (choixgore == "oui")
            {
                Console.WriteLine("scène gore activé\n\n");
                Console.ReadKey();
                goto start;
            }
            if (choixgore == "non")
            {
                gore = false;
                Console.WriteLine("scène gore désactivé\n\n");
                Console.ReadKey();
                goto fin;
            }
            else
            {
                Console.WriteLine("\ndésoler ce n'est pas une option\n");
                Console.ReadKey();
                goto messgore;
            }
        start:;
            //COMPTEUR AUTRES
            int contvoit = 1;

            //COMPTEUR POUR EASTER EGG
            int contras = 0;//suicidaire rasoir
            int contportm = 0;//destin famille

            //CONAISSANCES
            string votre_femme = "votre femme";
            string votre_fils = "votre fils";
            string votre_fille = "votre fille";

            //ACTIONS
            bool rasoir = false;
            bool bain = false;
            bool note = false;
            bool bon_mat_f = false;
            bool bon_mat_e = false;
            bool tutoQTE = false;
            bool revientafAM = false;
            bool revientafPM = false;
            bool visiterét1 = false;
            bool visiterét2 = false;
            bool visiterét3 = false;//si tout étage false succès arrivé a l'heure et dialogue positif avec patron //si tout étage true succès déja-vu et dialogue négatif avec patron
            bool visiterét4 = false;
            bool mangerlapin = false;
            bool suicide = false;

            //OBJETS
            bool sac_à_lunch = false;
            bool habits = false;//variable qui vérifie la sortie de la chambre

            //QTE réussi ou non
            bool QTEfamd = true;//QTE avec la famille avant d'aller au travail
            bool QTEascen = true;//QTE pour ne pas manger les collègues devant l'assenceur

            //QTE fait ou non et suite branches
            bool QTEfamdf = false;
            bool QTEascenf = false;
            bool branche_parking = false;


            string choixchamb = " ";
            Console.WriteLine("vous vous réveillez dans votre lit, votre femme est déja levée.");
            Console.ReadKey();
            Console.WriteLine("vous vous levez de votre lit et observez autour de vous.");
            Console.ReadKey();
        chambre:;
            Console.WriteLine("dans votre chambre vous voyez la porte des [toilettes], la porte qui mène au [couloir] d'ou vous sentez une bonne odeur.");
            Console.ReadKey();
            Console.WriteLine("il y a la [fenetre] devant vous et sur votre commode des [habits].");
            Console.ReadKey();
            Console.Write("où voulez vous aller?");
            Console.Write(" : ");
            choixchamb = Convert.ToString(Console.ReadLine());
            switch (choixchamb)
            {
                case "habits": //obligatoire
                    {
                        if (habits == false)
                        {
                            Console.WriteLine("\nvous enfilez pour la cinquième fois cette semaine un costume 3 pièce gris");
                            Console.ReadKey();
                            Console.WriteLine("vous mettez votre cravate bleue.");
                            Console.ReadKey();
                            Console.WriteLine("puis vous déposez votre pyjama sur la commode\n");
                            Console.ReadKey();
                            habits = true;
                            goto chambre;
                        }
                        if (habits == true)
                        {
                            Console.WriteLine("\nvous ne voyez que votre pyjama sur la commode.");
                            Console.ReadKey();
                            Console.WriteLine("vous êtes prêt pour aller travailler.\n");
                            Console.ReadKey();
                            goto chambre;
                        }
                    }
                    break;

                case "toilettes"://optionnel
                    {
                        string choixbain = " ";
                        Console.WriteLine("\nvous entrez dans votre salle de bain et vous sentez un frisson vous parcourir le corps.");
                        Console.ReadKey();
                    salledebain:;
                        Console.WriteLine("vous retrouvez votre [bain] devant vous, votre lavabo avec un [miroir] au dessus à votre gauche.");
                        Console.ReadKey();
                        Console.WriteLine("votre [rasoir] est posé sur le lavabo et les [toilettes] sont à votre droite.");
                        Console.ReadKey();
                        Console.WriteLine("il y a aussi la [porte] qui mène à votre chambre derrière vous.");
                        Console.ReadKey();
                        Console.Write("que voulez vous faire : ");
                        choixbain = Convert.ToString(Console.ReadLine());
                        switch (choixbain)
                        {
                            case "porte"://retour
                                {
                                    Console.WriteLine("\nvous soupirez, puis vous sortez de la salle de bain en refermant la porte derrière vous.\n");
                                    Console.ReadKey();
                                    goto chambre;
                                }
                                break;

                            case "miroir":
                                {
                                    Console.WriteLine("\nvous tournez la tête à gauche et regardez dans votre miroir.");
                                    Console.ReadKey();
                                    Console.WriteLine("vous soupirez.");
                                    Console.ReadKey();
                                    Console.WriteLine("vous ne vous reconnaissez toujours pas.");
                                    Console.ReadKey();
                                    Console.WriteLine("vous regardez autour de vous.\n");
                                    Console.ReadKey();
                                    goto salledebain;
                                }
                                break;

                            case "rasoir":
                                {

                                    if (contras == 0)
                                    {
                                        Console.WriteLine("\nvous vous approchez du lavabo.");
                                        Console.ReadKey();
                                        Console.WriteLine("vous prenez votre rasoir et commencez à vous raser.");
                                        Console.ReadKey();
                                        Console.WriteLine("vous vous coupez en vous rasant et en levant les yeux vers le mirroir vous voyez qu'ils ont changés");//indice sur l'histoire
                                        Console.ReadKey();
                                        Console.WriteLine("vous essuyez difficilement le sang sur votre joue.");
                                        Console.ReadKey();
                                        Console.WriteLine("vous finissez de vous raser et observez le rasoir pendant quelques secondes avant de le reposer.\n");
                                        Console.ReadKey();
                                        contras = contras + 1;
                                        rasoir = true;
                                        goto salledebain;
                                    }
                                    if (contras == 3) //easter egg teaser
                                    {
                                        Console.WriteLine("\nvous : je ne suis pas encore sur d'en être capable.\n");
                                        contras = contras + 1;
                                        Console.ReadKey();
                                        goto salledebain;
                                    }
                                    else
                                    {
                                        Console.WriteLine("je me suis déja rasé.\n");
                                        contras = contras + 1;
                                        Console.ReadKey();
                                        goto salledebain;
                                    }
                                }
                                break;

                            case "toilettes":
                                {
                                    Console.WriteLine("\nvous tournez la tête à droite vers votre toilette.");
                                    Console.ReadKey();
                                    Console.WriteLine("je n'ai pas envie d'aller au toilette\n");
                                    Console.ReadKey();
                                    goto salledebain;
                                }
                                break;

                            case "bain":
                                {
                                    if (bain == false)
                                    {
                                        Console.WriteLine("\nvous faites couler de l'eau brulante dans le bain.");
                                        Console.ReadKey();
                                        Console.WriteLine("une fois qu'il est rempli vous entrez dedans.");
                                        Console.ReadKey();
                                        Console.WriteLine("vous vous rappelez l'époque lointaine où la chaleur de l'eau vous réconfortait");
                                        Console.ReadKey();
                                        Console.WriteLine("cela fait longtemps qu'elle ne vous fait plus rien.\n");
                                        Console.ReadKey();
                                        bain = true;
                                        goto salledebain;
                                    }
                                    if (bain == true)
                                    {
                                        Console.WriteLine("vous vous êtes déja lavé.");
                                        Console.ReadKey();
                                        goto salledebain;
                                    }
                                }
                                break;

                            default:
                                {
                                    Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                    Console.ReadKey();
                                    goto salledebain;
                                }
                                break;
                        }
                    }
                    break;

                case "fenetre"://optionnel
                    {
                        Console.WriteLine("\nvous vous approchez de la fenêtre, ouvrez les rideaux et regardez dehors.");
                        Console.ReadKey();
                        Console.WriteLine("le soleil est caché par une épaisse couche de nuages et les gens courent vers leur voiture pour arriver au travail à temps.");
                        Console.ReadKey();
                        Console.WriteLine("vous souriez légèrement puis vous faite demi-tour.\n");
                        Console.ReadKey();
                        goto chambre;
                    }
                    break;

                case "couloir"://obligatoire
                    {
                        if (habits == false)
                        {
                            Console.WriteLine("\nvous : je ferais mieux de m'habiller pour le travail tant que je suis dans ma chambre.\n");
                            Console.ReadKey();
                            goto chambre;
                        }
                        else
                        {
                            string choixcoul = " ";
                            Console.WriteLine("\nvous ouvrez la porte de votre chambre et suivez la bonne odeur jusqu'au couloir.");
                            Console.ReadKey();
                        couloir:;
                            Console.WriteLine("la porte de la chambre des [enfants] est ouverte.");
                            Console.ReadKey();
                            Console.WriteLine("vous avez la [porte] d'entrée derrière vous ainsi que celle de votre [chambre].");
                            Console.ReadKey();
                            if (QTEfamd == true)
                            {
                                Console.WriteLine("vous entendez des rires d'enfant depuis la [cuisine].");
                                Console.ReadKey();
                            }
                            if (QTEfamd == false)
                            {
                                Console.WriteLine("il y a la [cuisine].");
                                Console.ReadKey();
                            }
                            Console.Write("où voulez vous aller? : ");
                            choixcoul = Convert.ToString(Console.ReadLine());

                            switch (choixcoul)
                            {
                                case "chambre": //retour
                                    {
                                        Console.WriteLine("\nvous faites demi-tour et vous retournez dans votre chambre.\n");
                                        Console.ReadKey();
                                        goto chambre;
                                    }
                                    break;

                                case "enfants": //optionnel
                                    {
                                        string chambenf = " ";
                                        Console.WriteLine("\nvous entrez dans la chambre de vos enfants.");
                                        Console.ReadKey();
                                    chambre_enfants:;
                                        Console.WriteLine("vous voyez les lits de votre fille et de votre fils avec une [photo] de famille au dessus.");
                                        Console.ReadKey();
                                        Console.WriteLine("il y a divers [travaux] manuels sur les murs.");
                                        Console.ReadKey();
                                        Console.WriteLine("il y a aussi du [papier] et un crayon sur leur bureau.");
                                        Console.ReadKey();
                                        Console.WriteLine("il y a la [porte] du couloir derrière vous.");
                                        Console.ReadKey();
                                        Console.Write("que voulez vous faire? : ");
                                        chambenf = Convert.ToString(Console.ReadLine());

                                        switch (chambenf)
                                        {
                                            case "porte":// retour
                                                {
                                                    Console.WriteLine("\nvous soupirez.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous quittez la chambre de vos enfants.\n");
                                                    Console.ReadKey();
                                                    goto couloir;
                                                }
                                                break;

                                            case "photo":
                                                {
                                                    Console.WriteLine("\nvous vous approchez des lit de vos enfant.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous regardez la photo au dessus du lit de votre fille.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous avez toujours préféré votre fille mais personne ne le sait.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("ce n'est pas la seul chose que les autres ne savent pas.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous avez vraiments de beaux enfants avec Béatrice\n");
                                                    Console.ReadKey();
                                                    votre_femme = "Béatrice";
                                                    goto chambre_enfants;
                                                }
                                                break;

                                            case "papier":
                                                {
                                                    if (note == false)
                                                    {
                                                        Console.WriteLine("\nvous vous approchez du bureau de vos enfants");
                                                        Console.ReadKey();
                                                        Console.WriteLine("vous prenez le crayon et écrivez une note chaleureuse pour vous enfants.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("ce sont de bons enfants ils le méritent.\n");
                                                        Console.ReadKey();
                                                        note = true;
                                                        goto chambre_enfants;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\nvous n'avez plus rien à faire ici.\n");
                                                        Console.ReadKey();
                                                        goto chambre_enfants;
                                                    }
                                                }
                                                break;

                                            case "travaux":
                                                {
                                                    Console.WriteLine("\nvous vous approchez du mur.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("dessus il y a des dessins et des collages fait par votre fille.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("elle a toujours été plus créative que Pierre");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous soupirez.\n");
                                                    Console.ReadKey();
                                                    votre_fils = "Pierre";
                                                    goto chambre_enfants;
                                                }
                                                break;

                                            default:
                                                {
                                                    Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                    Console.ReadKey();
                                                    goto chambre_enfants;
                                                }
                                                break;
                                        }

                                    }
                                    break;

                                case "cuisine": //optionnel
                                    {
                                        if (QTEfamd == true)
                                        {
                                            string choixcui = " ";
                                            Console.WriteLine("\nvous vous dirigez vers la cuisine où l'odeur agréable s'intensifie");
                                            Console.ReadKey();
                                        cuisine:;
                                            Console.WriteLine("vous voyez " + votre_fils + " et " + votre_fille + " jouer à la [table] à manger en mangeant leur céréales.");
                                            Console.ReadKey();
                                            Console.WriteLine("vous voyez " + votre_femme + " devant le [comptoir] qui prépare les dîners des enfants.");
                                            Console.ReadKey();
                                            Console.WriteLine("sur le comptoir à coté de " + votre_femme + " il y a un [sac].");
                                            Console.ReadKey();
                                            Console.WriteLine("il y a le [couloir] derrière vous.");
                                            Console.ReadKey();
                                            Console.WriteLine("vous avez chaud.");
                                            Console.ReadKey();
                                            Console.Write("que voulez vous faire? : ");
                                            choixcui = Convert.ToString(Console.ReadLine());

                                            switch (choixcui)
                                            {
                                                case "couloir": //retour
                                                    {
                                                        Console.WriteLine("\nvous rassemblez vos forces et faites demi-tour en ignorant la délicieuse odeur.\n");
                                                        Console.ReadKey();
                                                        goto couloir;
                                                    }
                                                    break;

                                                case "table":
                                                    {

                                                        if (bon_mat_e == false)
                                                        {
                                                            Console.WriteLine("\nvous vous approchez de vos enfants.");
                                                            Console.ReadKey();
                                                            Console.WriteLine("vous sentez une goutte de sueur perler sur votre font");
                                                            Console.ReadKey();
                                                            int i = 0;
                                                            if (tutoQTE == false)
                                                            {
                                                                Console.WriteLine("\nACTION DE RÉSISTER : Lorsque [RÉSISTEZ] s'affiche à l'écran vous pouvez perdre le controle de votre corps dans certaines situations.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("pour garder le controle appuyer 10 fois de suite rapidement sur votre touche entrée dans le temps imparti.\n");
                                                                Console.ReadKey();
                                                                tutoQTE = true;
                                                            }
                                                            Console.WriteLine("3");
                                                            Thread.Sleep(1000);
                                                            Console.WriteLine("2");
                                                            Thread.Sleep(1000);
                                                            Console.WriteLine("1");
                                                            Thread.Sleep(1000);
                                                            Console.WriteLine("[RÉSISTEZ]");
                                                            DateTime datea = DateTime.Now;//enregistre l'heur avant le QTE
                                                            do
                                                            {
                                                                Console.ReadKey(); i++;
                                                            } while (i < 10);//nombre de fois que l'utilisateur dois appuyer
                                                            DateTime dateb = DateTime.Now;//enregistre l'heur apres le QTE
                                                            Console.WriteLine("QTE terminé");
                                                            Thread.Sleep(3000);//délai pour ne pas passer la suite de l'histoire
                                                            TimeSpan res = dateb.Subtract(datea);//soustrait l'heur du début à l'heur de fin
                                                            double resu = res.TotalSeconds;//converti le résultat en double en secondes
                                                            Console.ReadKey();
                                                            if (resu < 2.2)
                                                            {
                                                                Console.WriteLine("\nréussi\n");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous embrassez sur le front " + votre_fille + ", puis " + votre_fils + ".");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous leur souhaitez une bonne journée et leur dites que vous le aimez.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous vous éloignez d'eux en soupirant.\n");
                                                                Console.ReadKey();
                                                                QTEfamdf = true;
                                                                bon_mat_e = true;
                                                                goto cuisine;
                                                            }

                                                            else
                                                            {
                                                                Console.WriteLine("\nraté\n");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous sentez une énorme chaleur envahir votre corps.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("...");
                                                                Console.ReadKey();
                                                                Console.WriteLine("...");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous oubliez ce qui c'est passé.\n");
                                                                Console.ReadKey();
                                                                QTEfamdf = true;
                                                                QTEfamd = false;
                                                                goto couloir;
                                                            }
                                                        }

                                                        if (bon_mat_e == true)
                                                        {
                                                            Console.WriteLine("\nvous : je devrais laisser les enfants finir de déjeuner ou ils risquent d'être en retard pour l'école.\n");
                                                            Console.ReadKey();
                                                            goto cuisine;
                                                        }

                                                    }
                                                    break;

                                                case "comptoir":
                                                    {

                                                        if (bon_mat_f == false)
                                                        {
                                                            Console.WriteLine("\n" + votre_femme + " vous souhaite bon matin et vous embrasse sur la joue.");
                                                            Console.ReadKey();
                                                            Console.WriteLine("vous lui souhaitez aussi bon matin.");
                                                            Console.ReadKey();
                                                            Console.WriteLine("vous avez très chaud.");
                                                            Console.ReadKey();
                                                            Console.WriteLine("ca ne vous arrive pas normalement");
                                                            Console.ReadKey();
                                                            Console.Write("...");
                                                            Console.ReadKey();
                                                            Console.Write("...");
                                                            Console.ReadKey();
                                                            Console.Write("...");
                                                            Console.ReadKey();
                                                            Console.WriteLine("pas avec eux.");
                                                            Console.ReadKey();
                                                            int i = 0;
                                                            if (tutoQTE == false)
                                                            {
                                                                Console.WriteLine("\nACTION DE RÉSISTER : Lorsque [RÉSISTEZ] s'affiche à l'écran vous pouvez perdre le controle de votre corps dans certaines situations.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("pour garder le controle appuyer 10 fois de suite rapidement sur votre touche entrée dans le temps imparti.\n");
                                                                Console.ReadKey();
                                                                tutoQTE = true;
                                                            }
                                                            Console.WriteLine("3");
                                                            Thread.Sleep(1000);
                                                            Console.WriteLine("2");
                                                            Thread.Sleep(1000);
                                                            Console.WriteLine("1");
                                                            Thread.Sleep(1000);
                                                            Console.WriteLine("[RÉSISTEZ]");
                                                            DateTime datea = DateTime.Now;//enregistre l'heur avant le QTE
                                                            do
                                                            {
                                                                Console.ReadKey(); i++;
                                                            } while (i < 10);//nombre de fois que l'utilisateur dois appuyer
                                                            DateTime dateb = DateTime.Now;//enregistre l'heur apres le QTE
                                                            Console.WriteLine("QTE terminé");
                                                            Thread.Sleep(3000);//délai pour ne pas passer la suite de l'histoire
                                                            TimeSpan res = dateb.Subtract(datea);//soustrait l'heur du début à l'heur de fin
                                                            double resu = res.TotalSeconds;//converti le résultat en double en secondes
                                                            Console.ReadKey();
                                                            if (resu < 2.2)
                                                            {
                                                                Console.WriteLine("\nréussi\n");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous voyez " + votre_femme + " écrire un mot pour le mettre dans la boîte à lunch de Agnès");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous prenez " + votre_femme + " dans vos bras, lui dites que vous l'aimez et lui souhaitez de passer une bonne journée");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous laissez " + votre_femme + " finir les lunch des enfants\n");
                                                                Console.ReadKey();
                                                                votre_fille = "Agnès";
                                                                QTEfamdf = true;
                                                                bon_mat_f = true;
                                                                goto cuisine;
                                                            }

                                                            else
                                                            {
                                                                Console.WriteLine("\nraté\n");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous sentez une énorme chaleur envahir votre corps.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("...");
                                                                Console.ReadKey();
                                                                Console.WriteLine("...");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous oubliez ce qui c'est passé.\n");
                                                                Console.ReadKey();
                                                                QTEfamdf = true;
                                                                QTEfamd = false;
                                                                goto couloir;
                                                            }
                                                        }

                                                        if (bon_mat_f == true)
                                                        {
                                                            Console.WriteLine("\nvous avez trop chaud pour lui reparler.\n");
                                                            Console.ReadKey();
                                                            goto cuisine;
                                                        }

                                                    }
                                                    break;

                                                case "sac":
                                                    {
                                                        if (sac_à_lunch == false)
                                                        {
                                                            Console.WriteLine("\nvous vous avancez vers le conptoir.");
                                                            Console.ReadKey();
                                                            Console.WriteLine("vous prenez votre sac à lunch.");
                                                            Console.ReadKey();
                                                            Console.WriteLine("vous vous éloignez du contoir.\n");
                                                            Console.ReadKey();
                                                            sac_à_lunch = true;
                                                            goto cuisine;
                                                        }
                                                        if (sac_à_lunch == true)
                                                        {
                                                            Console.WriteLine("\nvous : j'ai déja pris mon lunch je n'est plus rien à faire là-bas.\n");
                                                            Console.ReadKey();
                                                            goto cuisine;
                                                        }
                                                    }
                                                    break;

                                                default:
                                                    {
                                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                        Console.ReadKey();
                                                        goto cuisine;
                                                    }
                                                    break;
                                            }

                                        }
                                        if (QTEfamd == false)
                                        {
                                            Console.WriteLine("\nil est temps d'aller au travail.\n");
                                            Console.ReadKey();
                                            goto couloir;
                                        }

                                    }
                                    break;

                                case "porte": //obligatoire
                                    {
                                        string choixalltrav;
                                        Console.WriteLine("\nvous enfilez vos mocassins.");
                                        Console.ReadKey();
                                        Console.WriteLine("vous mettez votre veste grise.");
                                        Console.ReadKey();
                                        Console.WriteLine("vous mettez un large chapeau noir.");
                                        Console.ReadKey();
                                        if (QTEfamd == true)
                                        {
                                            Console.WriteLine("vous vous retournez vers la cuisine attiré par la bonne odeur.");
                                            Console.ReadKey();
                                            Console.WriteLine("vous soupirez et faite demi-tour");
                                            Console.ReadKey();
                                        }
                                        if (QTEfamd == false)
                                        {
                                            Console.WriteLine("vous sentez que la bonne odeur de la cuisine c'est grandement intensifiée");
                                            Console.ReadKey();
                                            Console.WriteLine("cela vous angoisse fortement.");
                                            Console.ReadKey();
                                        }
                                        Console.WriteLine("vous sortez dehors en fermant la [porte] derrière vous.");
                                        Console.ReadKey();
                                        Console.WriteLine("vous regardez votre montre.");
                                        Console.ReadKey();
                                    allerautaf:;//fait disparaitre l'option porte pour cacher l'easter egg
                                        Console.WriteLine("il est l'heure d'aller au travail");
                                        Console.ReadKey();
                                        Console.WriteLine("votre [voiture] est devant la maison.");
                                        Console.ReadKey();
                                        Console.Write("où voulez vous aller? : ");
                                        choixalltrav = Convert.ToString(Console.ReadLine());

                                        switch (choixalltrav)
                                        {
                                            case "porte":
                                                {
                                                    if (QTEfamd == false)
                                                    {
                                                        if (contportm == 3)//easter egg et indice
                                                        {
                                                            Console.WriteLine("\nvous vous doutez mais ne voulez savoir.\n");
                                                            Console.ReadKey();
                                                            contportm = contportm + 1;
                                                            goto allerautaf;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("\nvous ne pouvez pas retourner chez vous.\n");
                                                            Console.ReadKey();
                                                            contportm = contportm + 1;
                                                            goto allerautaf;
                                                        }
                                                    }
                                                    if (QTEfamd == true)
                                                    {
                                                        Console.WriteLine("\nvous ne pouvez pas retourner chez vous.\n");
                                                        Console.ReadKey();
                                                        goto allerautaf;
                                                    }
                                                }
                                                break;

                                            case "voiture":
                                                {
                                                    Console.WriteLine("\nvous entrez dans votre voiture.");
                                                    Console.ReadKey();
                                                    if (sac_à_lunch == true)
                                                    {
                                                        Console.WriteLine("vous déposez votre lunch sur la banquette arrière.");
                                                        Console.ReadKey();
                                                    }
                                                    Console.WriteLine("vous démarrez le contact et reculez la voiture dans l'allée.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous soupirez.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous : une nouvelle journée de travail commence.\n");
                                                    Console.ReadKey();
                                                    //********************** FIN DÉMO DÉBUT JEU COMPLET retirez le goto confin; pour tester contenu *************************************
                                                    Console.WriteLine("vous commencez à rouler vers la ville.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous profitez d'être en avance pour prendre votre temps sur le trajet.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous sortez du quartier résidentiel.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous passez devant une forêt.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous êtes pensif.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("vous passez devant une station service.");
                                                    Console.ReadKey();
                                                    if (QTEfamdf == true)
                                                    {
                                                        Console.WriteLine("vous : je le fait tous les jours normalement.");
                                                        Console.ReadKey();
                                                    }
                                                    Console.WriteLine("vous passez sur le pont qui mène à la ville.");
                                                    Console.ReadKey();
                                                    if (QTEfamdf == true)
                                                    {
                                                        Console.WriteLine("vous : ce n'est pas si dur normalement.");
                                                        Console.ReadKey();
                                                    }
                                                    Console.WriteLine("vous arrivez en ville.");
                                                    Console.ReadKey();
                                                    if (QTEfamdf == true)
                                                    {
                                                        Console.WriteLine("vous êtes inquiet.");
                                                        Console.ReadKey();
                                                    }
                                                    Console.WriteLine("vous vous dirigez vers le bâtiment dans lequel vous travaillez.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("une fois arrivé vous allez garer votre voiture dans le parking.\n");
                                                    Console.ReadKey();
                                                forêt:;//************************************************************************************************************************************************
                                                    if (branche_parking == true)
                                                    {
                                                        if (revientafAM == true)
                                                        {
                                                            if (QTEfamd == true)
                                                            {
                                                                Console.WriteLine("vous vous dirigez vers la sortie de la ville.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("???? : nous savons que c'est la seul option.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("???? : le moment est venu.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("???? : il faut les protéger.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous arrivez au milieu du pont pour sortir de la ville.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous dépassez la station sevice.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous vous arrêtez devant la forêt que vous avez vu ce matin.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous : l'heur est venue.\n");
                                                                Console.ReadKey();
                                                            forêtstart:;
                                                                string choixforêtstart = " ";
                                                                Console.WriteLine("devant vous il y a un [sentier].");
                                                                Console.ReadKey();
                                                                Console.WriteLine("derrière vous il y a votre [voiture]");
                                                                Console.ReadKey();
                                                                Console.Write("où voulez vous aller? : ");
                                                                choixforêtstart = Convert.ToString(Console.ReadLine());

                                                                switch (choixforêtstart)
                                                                {
                                                                    case "voiture":
                                                                        {
                                                                            Console.WriteLine("\nvous : je suis allé trop loin cette fois.");
                                                                            Console.ReadKey();
                                                                            Console.WriteLine("vous : je ne peux plus revenir en arrière.\n");
                                                                            Console.ReadKey();
                                                                            goto forêtstart;
                                                                        }
                                                                        break;

                                                                    case "sentier":
                                                                        {
                                                                            Console.WriteLine("\nvous entrez dans la forêt.");
                                                                            Console.ReadKey();
                                                                            Console.WriteLine("les arbres sont tellement épais que vous ne voyez plus le ciel.");
                                                                            Console.ReadKey();
                                                                        sentier1:;
                                                                            string choixsentier1 = " ";
                                                                            Console.WriteLine("devant vous il y a la suite du [sentier].");
                                                                            Console.ReadKey();
                                                                            Console.WriteLine("vous avez faim et vous sentez une bonne [odeur] à votre droite.");
                                                                            Console.ReadKey();
                                                                            Console.WriteLine("où voulez vous aller? : ");
                                                                            choixsentier1 = Convert.ToString(Console.ReadLine());

                                                                            switch (choixsentier1)
                                                                            {
                                                                                case "odeur":
                                                                                    {
                                                                                        Console.WriteLine("\nvous suivez l'odeur.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("elle vous mène jusqu'a un lapin qui est prit dans un piège et qui a une coupure à la patte.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("vous vous approchez du lapin.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("vous lui sautez dessus et lui mordez le coup pour lui sucer le sang.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("???? : tu n'arrive plus à contrôler ta faim il faut en finir vite.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("vous retournez sur le sentier paniqué.\n");
                                                                                        Console.ReadKey();
                                                                                        mangerlapin = true;
                                                                                        goto sentier1;
                                                                                    }
                                                                                    break;

                                                                                case "sentier":
                                                                                    {
                                                                                        Console.WriteLine("\nvous avancez sur le [sentier] jusqu'a un [croisement].");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("");
                                                                                        Console.ReadKey();
                                                                                        goto confin;
                                                                                    }
                                                                                    break;

                                                                                default:
                                                                                    {
                                                                                        Console.WriteLine("\nvous soupirez en étant confus car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                        Console.ReadKey();
                                                                                        goto sentier1;
                                                                                    }
                                                                                    break;
                                                                            }
                                                                        }
                                                                        break;

                                                                    default:
                                                                        {
                                                                            Console.WriteLine("\nvous soupirez en étant confus car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                            Console.ReadKey();
                                                                            goto forêtstart;
                                                                        }
                                                                        break;
                                                                }

                                                            }
                                                            if (QTEfamd == false)
                                                            {
                                                                Console.WriteLine("vous vous dirigez vers la sortie de la ville.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("???? : nous savons que c'est la seul option.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("???? : nous ne pouvons plus le nier.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("???? : pas pour eux.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous : pas pour eux.");
                                                                Console.ReadKey();
                                                                Console.WriteLine("vous arrivez au milieu du pont pour sortir de la ville.\n");
                                                                Console.ReadKey();
                                                                int i = 0;
                                                                Console.WriteLine("3");
                                                                Thread.Sleep(1000);
                                                                Console.WriteLine("2");
                                                                Thread.Sleep(1000);
                                                                Console.WriteLine("1");
                                                                Thread.Sleep(1000);
                                                                Console.WriteLine("[RÉSISTEZ]");
                                                                DateTime datea = DateTime.Now;//enregistre l'heur avant le QTE
                                                                do
                                                                {
                                                                    Console.ReadKey(); i++;
                                                                } while (i < 10);//nombre de fois que l'utilisateur dois appuyer
                                                                DateTime dateb = DateTime.Now;//enregistre l'heur apres le QTE
                                                                Console.WriteLine("QTE terminé");
                                                                Thread.Sleep(3000);//délai pour ne pas passer la suite de l'histoire
                                                                TimeSpan res = dateb.Subtract(datea);//soustrait l'heur du début à l'heur de fin
                                                                double resu = res.TotalSeconds;//converti le résultat en double en secondes
                                                                Console.ReadKey();
                                                                if (resu > 3.5)
                                                                {
                                                                    Console.WriteLine("\nraté\n");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("vous sortez du déni.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("vous prenez pleinement conscience de ce que vous avez fait.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("vous vous êtes nourrit de votre famille.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("vous arrêtez votre voiture au millieu du pont.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine(votre_femme);
                                                                    Console.ReadKey();
                                                                    Console.WriteLine(votre_fils);
                                                                    Console.ReadKey();
                                                                    Console.WriteLine(votre_fille);
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("vous n'avez pas su contrôler votre faim et vous les avez tués.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("la nouvelle vous dévaste.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("vous arrachez violament la portière avant de votre voiture en bondissant hors de celle-ci.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("vous attérissez sur le rebord du pont.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("vous sautez.");
                                                                    Console.ReadKey();
                                                                    if (gore == true)
                                                                    {
                                                                        Console.WriteLine("vous vous sentez tomber.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("en dessous de vous il y a une rivière avec un fort courrant qui mène à une cascade.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("à mesure que la rivière se rapproche vous sentez vos pied passez devant.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous vous écraser sur l'eau pied devant avec un bruit de craquement d'os.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous ne sentez plus vos jambes.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous criez mais vos poumons se remplissent d'eau.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous êtes attiré vers la chute d'eau.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous heurtez un rocher.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("l'eau autour de vous devient rouge alors que vous ne sentez plus votre bras gauche.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous êtes réconfortez par la pensée que votre famille était vos dernières victimes.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous êtes arrivez à la chute d'eau.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("???? : c'était la meilleur option.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous avez à peine le temps de sentir que vous tomber que votre tête touche un rocher en bas.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous sentez pendant quelques brève millisecondes l'énorme douleur de votre tête qui explose au contact du rocher.");
                                                                        Console.ReadKey();
                                                                    }
                                                                    Console.WriteLine("\n\n2 jours plus tard.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("...");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("\nprésentateur : Bonjours chère téléspectateur et bienvenu au journal de 18h.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("présentateur : Le corps d'une mère, de son fils et de ça fille ont été retrouvés sans vie ce matin à leur domicile.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("présentateur : Les trois corps présentent deux marques circulaires au niveau de la carotide et on été vidés de leur sang.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("présentateur : Le mari de la famille reste introuvable et les forces de l'ordre l'ont pris comme suspect principal dans cette affaire.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("présentateur : Dans la continuité de l'ambiance morbide de ce journal nous avons enfin une bonne nouvelle concernant l'affaire de l'homme qui a sauté du pont sud de la ville il y a deux jours.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("présentateur : Ce matin les équipes de recherches ont retrouvé un morceau de bras dans la rivière.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("présentateur : Il est actuellement en analyse pour découvrir l'identitée de l'homme qui à sauté.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("présentateur : Les équipes n'ont malheureusement pas retrouvé le reste du corps qui à selon eux chuter en bas de la cascade et est donc introuvable.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("présentateur : Ce sera tout pour le journal de 18h nous nous retrouvons demain avec espéront le des nouvelles plus réjouissantes.\n");
                                                                    Console.ReadKey();
                                                                    suicide = true;
                                                                    finpont = true;
                                                                    if (finpont == true)
                                                                    {
                                                                        nbdefindécouvertes = nbdefindécouvertes + 1;
                                                                    }
                                                                    goto confin;//*********************************************** fin pont ******************************************************************************************

                                                                }
                                                                Console.WriteLine("");//*************************************copier coller le case true ici*****************************************************************************
                                                                Console.ReadKey();

                                                            }
                                                        }

                                                        if (revientafPM == true)
                                                        {
                                                            if (QTEfamd == true)
                                                            {
                                                                //******************************************************** coder suite fin après travail *****************************************
                                                                goto confin;
                                                                Console.WriteLine("");
                                                                Console.ReadKey();
                                                            }
                                                            if (QTEfamd == false)
                                                            {
                                                                //******************************************************** coder suite fin après travail *****************************************
                                                                goto confin;
                                                                Console.WriteLine("");
                                                                Console.ReadKey();
                                                            }
                                                        }
                                                        Console.WriteLine("vous sortez de votre voiture à l'entrée d'une épaisse forêt.");
                                                        Console.ReadKey();

                                                    }
                                                    else
                                                    {
                                                    pbureau:;
                                                        if (branche_parking == true) //suite au bureau
                                                        {
                                                            Console.WriteLine("vous regardez autour de vous.");
                                                            Console.ReadKey();
                                                        }
                                                        if (QTEascenf == true)
                                                            Console.WriteLine("\nvous garez votre voiture dans le parking du bâtiment.");//début séquence parking
                                                        Console.ReadKey();
                                                        if (sac_à_lunch == true)
                                                        {
                                                            string lunch = "";
                                                        lunch:;
                                                            Console.WriteLine("votre lunch est sur la banquette arrière.");
                                                            Console.ReadKey();
                                                            Console.Write("voulez vous le prendre? [oui] [non] : ");
                                                            lunch = Convert.ToString(Console.ReadLine());
                                                            switch (lunch)
                                                            {
                                                                case "oui":
                                                                    {
                                                                        Console.WriteLine("\nvous ramasser votre lunch.\n");
                                                                        Console.ReadKey();
                                                                    }
                                                                    break;

                                                                case "non":
                                                                    {
                                                                        sac_à_lunch = false;
                                                                    }
                                                                    break;

                                                                default:
                                                                    {
                                                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                        Console.ReadKey();
                                                                        goto lunch;
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        string parking = " ";
                                                        Console.WriteLine("vous sortez de la voiture et la fermez à clef.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("vous êtes à l'heure.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("il est 8h00.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("vous vous dirigez vers la sortie du parking");
                                                        Console.ReadKey();
                                                    parking:;
                                                        Console.WriteLine("vous êtes devant une porte d'[ascenseur].");
                                                        Console.ReadKey();
                                                        Console.WriteLine("à coté il y a un [escalier]");
                                                        Console.ReadKey();
                                                        Console.WriteLine("votre [voiture] est à quelques mètres derrière vous.");
                                                        Console.ReadKey();
                                                        Console.Write("où voulez vous aller? : ");
                                                        parking = Convert.ToString(Console.ReadLine());

                                                        switch (parking)
                                                        {
                                                            case "ascenseur":
                                                                {
                                                                    if (QTEascen == true && QTEascenf == true)
                                                                    {
                                                                        Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous entrez dans l'assenseur.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("les portes se referment.");
                                                                        Console.ReadKey();

                                                                    }
                                                                ascenceurfail:;
                                                                    if (QTEascen == false)
                                                                    {
                                                                        string étageacctu = "RC";
                                                                        string choixétage = " ";
                                                                        Console.WriteLine("\nvous appuyez sur le boutton pour appeler l'ascenseur.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("il est au 5ièm étage.");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("il est au 4ièm étage.");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("il est au 3ièm étage.");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("il est au 2ièm étage.");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("il est au 1er étage.");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("il est au rez-de-chaussé.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous entrez dans l'assenseur.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("les portes se referment.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("il est 9h00.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous êtes en retard.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous avez mal aux gencives.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vos mocassins sont plein de boue et de feuilles.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("vous savez pourquoi.");
                                                                        Console.ReadKey();
                                                                    ascenseur:;
                                                                        Console.WriteLine("il y a 6 bouttons dans l'ascenseur.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("[RC],[1],[2],[3],[4] et [5].");
                                                                        Console.ReadKey();
                                                                        Console.Write("sur quel bouton appuyez vous? : ");
                                                                        choixétage = Convert.ToString(Console.ReadLine());

                                                                        switch (choixétage)
                                                                        {
                                                                            case "RC":
                                                                                {
                                                                                    if (étageacctu == "RC" || étageacctu == "rc")
                                                                                    {
                                                                                        Console.WriteLine("\nvous appuyez sur le bouton RC.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("il ne se passe rien.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("vous : je suis déja au rez-de-chaussée.\n");
                                                                                        goto ascenseur;
                                                                                    }

                                                                                    Console.WriteLine("\nvous : je suis déja assez en retard. je devrais aller travailler\n");
                                                                                    Console.ReadKey();
                                                                                    étageacctu = "RC";
                                                                                }
                                                                                break;

                                                                            case "1":
                                                                                {
                                                                                    if (étageacctu == "1")
                                                                                    {
                                                                                        Console.WriteLine("\nvous appuyez sur le bouton RC.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("il ne se passe rien.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("vous : je suis déja au 1er étage.\n");
                                                                                        goto ascenseur;
                                                                                    }

                                                                                    Console.WriteLine("\nvous : je suis déja assez en retard. je devrais aller travailler\n");
                                                                                    Console.ReadKey();
                                                                                    étageacctu = "RC";
                                                                                }
                                                                                break;

                                                                            case "2":
                                                                                {
                                                                                    if (étageacctu == "2")
                                                                                    {
                                                                                        Console.WriteLine("\nvous appuyez sur le bouton RC.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("il ne se passe rien.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("vous : je suis déja au 2ièm étage.\n");
                                                                                        goto ascenseur;
                                                                                    }

                                                                                    Console.WriteLine("\nvous : je suis déja assez en retard. je devrais aller travailler\n");
                                                                                    Console.ReadKey();
                                                                                    étageacctu = "RC";
                                                                                }
                                                                                break;

                                                                            case "3":
                                                                                {
                                                                                    if (étageacctu == "3")
                                                                                    {
                                                                                        Console.WriteLine("\nvous appuyez sur le bouton RC.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("il ne se passe rien.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("vous : je suis déja au 3ièm étage.\n");
                                                                                        goto ascenseur;
                                                                                    }

                                                                                    Console.WriteLine("\nvous : je suis déja assez en retard. je devrais aller travailler\n");
                                                                                    Console.ReadKey();
                                                                                    étageacctu = "RC";
                                                                                }
                                                                                break;

                                                                            case "4":
                                                                                {
                                                                                    if (étageacctu == "4")
                                                                                    {
                                                                                        Console.WriteLine("\nvous appuyez sur le bouton RC.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("il ne se passe rien.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("vous : je suis déja au 4ièm étage.\n");
                                                                                        goto ascenseur;
                                                                                    }

                                                                                    Console.WriteLine("\nvous : je suis déja assez en retard. je devrais aller travailler\n");
                                                                                    Console.ReadKey();
                                                                                    étageacctu = "RC";
                                                                                }
                                                                                break;

                                                                            case "5":
                                                                                {
                                                                                    if (étageacctu == "5")
                                                                                    {
                                                                                        Console.WriteLine("\nvous appuyez sur le bouton RC.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("il ne se passe rien.");
                                                                                        Console.ReadKey();
                                                                                        Console.WriteLine("vous : je suis déja au 5ièm étage.\n");
                                                                                        goto ascenseur;
                                                                                    }

                                                                                    Console.WriteLine("\nvous sentez l'ascenseur monter.");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("l'ascenseur s'arrête au 5ièm étage.");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                    Console.ReadKey();
                                                                                    étageacctu = "5";
                                                                                    goto pbureau;
                                                                                }
                                                                                break;

                                                                            default:
                                                                                {
                                                                                    Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                    Console.ReadKey();
                                                                                    goto ascenceurfail;
                                                                                }
                                                                                break;

                                                                        }

                                                                    }
                                                                    double resu = 0;
                                                                    if (QTEascen == true)
                                                                    {

                                                                        Console.WriteLine("\nvous appuyez sur le boutton pour appeler l'ascenseur.");
                                                                        Console.ReadKey();
                                                                        Console.WriteLine("il est au 5ièm étage.");
                                                                        Thread.Sleep(2500);
                                                                        Console.WriteLine("vous sentez une bonne odeur.");
                                                                        Thread.Sleep(2250);
                                                                        Console.WriteLine("il est au 4ièm étage.");
                                                                        Thread.Sleep(2000);
                                                                        Console.WriteLine("l'odeur s'intensifie.");
                                                                        Thread.Sleep(1750);
                                                                        Console.WriteLine("il est au 3ièm étage.");
                                                                        Thread.Sleep(1500);
                                                                        Console.WriteLine("l'odeur s'intensifie.");
                                                                        Thread.Sleep(1250);
                                                                        Console.WriteLine("il est au 2ièm étage.");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("l'odeur s'intensifie.");
                                                                        Thread.Sleep(975);
                                                                        Console.WriteLine("il est au 1er étage.");
                                                                        Thread.Sleep(1000);
                                                                        Console.Write("L'ODEUR! ");
                                                                        Thread.Sleep(2000);
                                                                        Console.WriteLine("S'INTENSIFIE!");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("il est au rez-de-chaussée.\n");
                                                                        Console.ReadKey();
                                                                        int i = 0;
                                                                        if (tutoQTE == false)
                                                                        {
                                                                            Console.WriteLine("\nACTION DE RÉSISTER : Lorsque [RÉSISTEZ] s'affiche à l'écran vous pouvez perdre le controle de votre corps dans certaines situations.");
                                                                            Console.ReadKey();
                                                                            Console.WriteLine("pour garder le controle appuyer 10 fois de suite rapidement sur votre touche entrée dans le temps imparti.\n");
                                                                            Console.ReadKey();
                                                                            tutoQTE = true;
                                                                        }
                                                                        Console.WriteLine("3");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("2");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("1");
                                                                        Thread.Sleep(1000);
                                                                        Console.WriteLine("[RÉSISTEZ]");
                                                                        DateTime datea = DateTime.Now;//enregistre l'heur avant le QTE
                                                                        do
                                                                        {
                                                                            Console.ReadKey(); i++;
                                                                        } while (i < 10);//nombre de fois que l'utilisateur dois appuyer
                                                                        DateTime dateb = DateTime.Now;//enregistre l'heur apres le QTE
                                                                        Console.WriteLine("QTE terminé");
                                                                        Thread.Sleep(3000);//délai pour ne pas passer la suite de l'histoire
                                                                        TimeSpan res = dateb.Subtract(datea);//soustrait l'heur du début à l'heur de fin
                                                                        resu = res.TotalSeconds;//converti le résultat en double en secondes
                                                                        Console.ReadKey();

                                                                        if (sac_à_lunch == true)
                                                                        {
                                                                            if (resu < 3)
                                                                            {
                                                                                Console.WriteLine("\nréussi\n");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("vous vous concentrez sur l'odeur de votre lunch.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("vous voyez 5 de vos collègues en sortir et elles se referment.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("ils sont restés au bureau toutes la nuit pour finir de remplir les papier de la comptabilitée.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("ils ont l'air d'épaves vides.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("vous les saluez mais ils sont trop fatigués pour faire de même.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("vous soupirez.");
                                                                                Console.ReadKey();
                                                                                QTEascen = true;
                                                                                QTEascenf = true;
                                                                                branche_parking = true;
                                                                                string étageacctu = "RC";
                                                                                string choixétage = " ";
                                                                            ascenseur:;
                                                                                Console.WriteLine("\nvous entrez dans l'ascenseur.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("les portes se referment");
                                                                                Console.ReadKey();
                                                                            étageacctu:;
                                                                                Console.WriteLine("il y a 6 bouttons dans l'ascenseur.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("[RC],[1],[2],[3],[4] et [5].");
                                                                                Console.ReadKey();
                                                                                Console.Write("sur quel bouton appuyez vous? : ");
                                                                                choixétage = Convert.ToString(Console.ReadLine());

                                                                                switch (choixétage)
                                                                                {
                                                                                    case "RC":
                                                                                        {
                                                                                            if (étageacctu == "RC" || étageacctu == "rc")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton RC.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au rez-de-chaussée.\n");
                                                                                                goto étageacctu;
                                                                                            }

                                                                                            Console.WriteLine("\nvous : je n'ai plus rien à faire ici.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "RC";
                                                                                        }
                                                                                        break;

                                                                                    case "1":
                                                                                        {
                                                                                            if (étageacctu == "1")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton RC.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au 1er étage.\n");
                                                                                                goto étageacctu;
                                                                                            }

                                                                                            Console.WriteLine("\nvous appuyez sur le bouton 1.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sentez l'ascenseur monter.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'ascenseur s'arrête au 1er étage.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "1";

                                                                                            string choixresto = " ";
                                                                                            Console.WriteLine("vous êtes dans l'entrée d'un restaurant.");
                                                                                            Console.ReadKey();
                                                                                        resto:;
                                                                                            Console.WriteLine("devant vous il y a des [portes] sur lesquelles il y a un [écriteau].");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'entrée est sombre et le resto semble vide.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("derrière vous il y a l'[ascenseur]");
                                                                                            Console.ReadKey();
                                                                                            Console.Write("que voulez vous faire? : ");
                                                                                            choixresto = Convert.ToString(Console.ReadLine());

                                                                                            switch (choixresto)
                                                                                            {
                                                                                                case "ascenseur":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous appuyez sur le bouton de l'ascenseur.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les portes de l'ascenseur s'ouvrent\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto ascenseur;
                                                                                                    }
                                                                                                    break;

                                                                                                case "portes":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous vous approchez des portes du restaurant et essayez de les ouvrir.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les portes sont fermées.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous entreaperçevez un homme et une femme à une table.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vou : ils ont dû réserver tout le resto.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous soupirez en vous remémorant votre rencontre avec " + votre_femme + ".\n");
                                                                                                        Console.ReadKey();
                                                                                                        visiterét1 = true;
                                                                                                        goto resto;
                                                                                                    }
                                                                                                    break;

                                                                                                case "écriteau":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous vous approchez des portes pour lire l'écriteau.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("il est écrit Fermé.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("en dessous il y a les horraires d'ouverture du restaurant");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous soupirez");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous : il n'ouvre au public qu'après mes heures de travail.\n");
                                                                                                        Console.ReadKey();
                                                                                                        visiterét1 = true;
                                                                                                        goto resto;
                                                                                                    }
                                                                                                    break;

                                                                                                default:
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto resto;
                                                                                                    }
                                                                                                    break;

                                                                                            }
                                                                                        }
                                                                                        break;

                                                                                    case "2":
                                                                                        {
                                                                                            if (étageacctu == "2")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton 2.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au 2ièm étage.\n");
                                                                                                goto étageacctu;
                                                                                            }

                                                                                            Console.WriteLine("\nvous appuyez sur le bouton 2.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sentez l'ascenseur monter.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'ascenseur s'arrête au 2ièm étage.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "2";
                                                                                        salledereception:;
                                                                                            string choixmarri = " ";
                                                                                            Console.WriteLine("vous êtes devant une [salle] de réception.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("il y a l'[ascenseur] derrière vous.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("où voulez vous aller? : ");
                                                                                            choixmarri = Convert.ToString(Console.ReadLine());

                                                                                            switch (choixmarri)
                                                                                            {
                                                                                                case "ascenseur":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous appuyez sur le bouton de l'ascenseur.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les portes de l'ascenseur s'ouvrent\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto ascenseur;
                                                                                                    }
                                                                                                    break;

                                                                                                case "salle":
                                                                                                    {

                                                                                                        Console.WriteLine("\nvous vous approchez de la salle.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les tables et la décorations sont toutes blanches.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("la salle est pleine de gens.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("ils ont l'air de célébrer un marriage.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous soupirez avec nostalgie et tristesse.\n");
                                                                                                        Console.ReadKey();
                                                                                                        visiterét2 = true;
                                                                                                        goto salledereception;
                                                                                                    }
                                                                                                    break;

                                                                                                default:
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto salledereception;
                                                                                                    }
                                                                                                    break;
                                                                                            }
                                                                                        }
                                                                                        break;

                                                                                    case "3":
                                                                                        {
                                                                                            if (étageacctu == "3")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton 3.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au 3ièm étage.\n");
                                                                                                goto étageacctu;
                                                                                            }

                                                                                            Console.WriteLine("\nvous appuyez sur le bouton 3.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sentez l'ascenseur monter.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'ascenseur s'arrête au 3ièm étage.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "3";

                                                                                            string choixclinique = " ";
                                                                                            bool porte = false;
                                                                                            Console.WriteLine("vous êtes dans une clinique de naissances privée.");
                                                                                            Console.ReadKey();
                                                                                        clinique:;
                                                                                            Console.WriteLine("devant vous il y a les [portes] de la salle d'attente.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("un peu plus loing vous voyez une [vitre].");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous entendez des cries depuis une des [salles].");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("derrière vous il y a l'[ascenseur].");
                                                                                            Console.ReadKey();
                                                                                            Console.Write("où voulez vous allez? : ");
                                                                                            choixclinique = Convert.ToString(Console.ReadLine());

                                                                                            switch (choixclinique)
                                                                                            {
                                                                                                case "ascenseur":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous appuyez sur le bouton de l'ascenseur.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les portes de l'ascenseur s'ouvrent\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto ascenseur;
                                                                                                    }
                                                                                                    break;

                                                                                                case "salles":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous entrez dans la salle d'attente.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("elle est remplie de femmes enceintes qui attendent une consultation.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("votre attention est attiré par une femme qui attend sans son mari pour l'accompagner.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous sentez une pression sur votre torse.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous sortez de la salle d'attente\n");
                                                                                                        Console.ReadKey();
                                                                                                        visiterét3 = true;
                                                                                                        goto clinique;
                                                                                                    }
                                                                                                    break;

                                                                                                case "vitre":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous vous approcher de la grande vitre rectangulaire.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("de l'autre côté il y a la garderie de la clinique.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("tout les berceaux ont au moins un bébé et certains en ont deux.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous vous éloignez de la vitre.\n");
                                                                                                        Console.ReadKey();
                                                                                                        visiterét3 = true;
                                                                                                        goto clinique;
                                                                                                    }
                                                                                                    break;

                                                                                                case "portes":
                                                                                                    {
                                                                                                        if (porte == false)
                                                                                                        {
                                                                                                            Console.WriteLine("\nvous vous apprrochez de la salle d'où proviennent les cris.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("quand vous arrivez devant la porte de la salle vous voyez une femme qui acouche.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("un médecin vous voit et ferme la porte de la salle");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("vous entendez le médecin dire qu'il doit procéder à une césarienne.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("un frisson vous parcours le dos.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("vous retournez d'où vous venez.\n");
                                                                                                            Console.ReadKey();
                                                                                                            visiterét3 = true;
                                                                                                            porte = true;
                                                                                                            goto clinique;
                                                                                                        }

                                                                                                        else
                                                                                                        {
                                                                                                            Console.WriteLine("\nvous ne voyez pas d'intérêt à retourner là bas.\n");
                                                                                                            Console.ReadKey();
                                                                                                            goto clinique;
                                                                                                        }
                                                                                                    }
                                                                                                    break;

                                                                                                default:
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto clinique;
                                                                                                    }
                                                                                                    break;
                                                                                            }

                                                                                        }
                                                                                        break;

                                                                                    case "4":
                                                                                        {
                                                                                            if (étageacctu == "4")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton 4.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au 4ièm étage.\n");
                                                                                                goto étageacctu;
                                                                                            }

                                                                                            Console.WriteLine("\nvous appuyez sur le bouton 4.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sentez l'ascenseur monter.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'ascenseur s'arrête au 4ièm étage.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "4";

                                                                                            string choixretraite = " ";
                                                                                            bool parlersecr = false;
                                                                                            Console.WriteLine("vous êtes dans une maison de retraite.");
                                                                                            Console.ReadKey();
                                                                                        retraite:;
                                                                                            Console.WriteLine("vous voyez la [secrétaire] devant vous derrière sont bureau.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous avez l'[ascenseur] derrière vous.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("où voulez vous aller? : ");
                                                                                            choixretraite = Convert.ToString(Console.ReadLine());

                                                                                            switch (choixretraite)
                                                                                            {
                                                                                                case "ascenseur":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous appuyez sur le bouton de l'ascenseur.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les portes de l'ascenseur s'ouvrent\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto ascenseur;

                                                                                                    }
                                                                                                    break;

                                                                                                case "secrétaire":
                                                                                                    {
                                                                                                        if (parlersecr == false)
                                                                                                        {
                                                                                                            Console.WriteLine("\nvous vous approchez du bureau de la secrétaire.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("elle vous dit bonjour et commence à vous décrire l'endroit.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("vous éccoutez à peine car vous êtes dans vos pensées.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("vous soupirez.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("vous éprouvez du regret en vous éloignant du bureau de la secrétaire.\n");
                                                                                                            Console.ReadKey();
                                                                                                            visiterét4 = true;
                                                                                                            goto retraite;
                                                                                                        }

                                                                                                        else
                                                                                                        {
                                                                                                            Console.WriteLine("\nvous ne voyez pas l'intérêt de reparler à la secrétaire.\n");
                                                                                                            Console.ReadKey();
                                                                                                            goto retraite;
                                                                                                        }
                                                                                                    }
                                                                                                    break;

                                                                                                default:
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto retraite;
                                                                                                    }
                                                                                                    break;
                                                                                            }
                                                                                        }
                                                                                        break;

                                                                                    case "5":
                                                                                        {
                                                                                            if (étageacctu == "5")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton 5.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au 5ièm étage.\n");
                                                                                                goto étageacctu;
                                                                                            }

                                                                                            Console.WriteLine("\nvous appuyez sur le bouton 5.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sentez l'ascenseur monter.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'ascenseur s'arrête au 5ièm étage.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "5";
                                                                                            goto pbureau;
                                                                                        }
                                                                                        break;

                                                                                    default:
                                                                                        {
                                                                                            Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                            Console.ReadKey();
                                                                                            goto ascenseur;
                                                                                        }
                                                                                        break;

                                                                                }
                                                                            }

                                                                            else
                                                                            {
                                                                                Console.WriteLine("\nraté\n");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("...");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("...");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("...");
                                                                                Console.ReadKey();
                                                                                QTEascen = false;
                                                                                QTEascenf = true;
                                                                                branche_parking = true;
                                                                                goto ascenceurfail;
                                                                            }
                                                                        }
                                                                        if (sac_à_lunch == false)
                                                                        {
                                                                            if (resu < 2)
                                                                            {
                                                                                Console.WriteLine("\nréussi\n");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("vous voyez 5 de vos collègues en sortir et elles se referment.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("ils sont restés au bureau toutes la nuit pour finir de remplir les papier de la comptabilitée.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("ils ont l'air d'épaves vides.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("vous les saluez mais ils sont trop fatigués pour faire de même.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("vous soupirez.");
                                                                                Console.ReadKey();
                                                                                QTEascen = true;
                                                                                QTEascenf = true;
                                                                                branche_parking = true;
                                                                                string étageacctu = "RC";
                                                                                string choixétage = " ";
                                                                            ascenseur:;
                                                                                Console.WriteLine("\nvous entrez dans l'assenseur.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("les portes se referment");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("il y a 6 bouttons dans l'ascenseur.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("[RC],[1],[2],[3],[4] et [5].");
                                                                                Console.ReadKey();
                                                                                Console.Write("sur quel bouton appuyez vous? : ");
                                                                                choixétage = Convert.ToString(Console.ReadLine());

                                                                                switch (choixétage)
                                                                                {
                                                                                    case "RC":
                                                                                        {
                                                                                            if (étageacctu == "RC")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton RC.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au rez-de-chaussée.\n");
                                                                                                goto ascenseur;
                                                                                            }

                                                                                            Console.WriteLine("\nvous : je n'ai plus rien à faire ici.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "RC";
                                                                                        }
                                                                                        break;

                                                                                    case "1":
                                                                                        {
                                                                                            if (étageacctu == "1")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton RC.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au 1er étage.\n");
                                                                                                goto ascenseur;
                                                                                            }

                                                                                            Console.WriteLine("\nvous appuyez sur le bouton 1.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sentez l'ascenseur monter.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'ascenseur s'arrête au 1er étage.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "1";

                                                                                            string choixresto = " ";
                                                                                            Console.WriteLine("vous êtes dans l'entrée d'un restaurant.");
                                                                                            Console.ReadKey();
                                                                                        resto:;
                                                                                            Console.WriteLine("devant vous il y a des [portes] sur lesquelles il y a un [écriteau].");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'entrée est sombre et le resto semble vide.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("derrière vous il y a l'[ascenseur]");
                                                                                            Console.ReadKey();
                                                                                            Console.Write("que voulez vous faire? : ");
                                                                                            choixresto = Convert.ToString(Console.ReadLine());

                                                                                            switch (choixresto)
                                                                                            {
                                                                                                case "ascenseur":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous appuyez sur le bouton de l'ascenseur.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les portes de l'ascenseur s'ouvrent\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto ascenseur;
                                                                                                    }
                                                                                                    break;

                                                                                                case "portes":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous vous approchez des portes du restaurant et essayez de les ouvrir.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les portes sont fermées.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous entreaperçevez un homme et une femme à une table.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vou : ils ont dû réserver tout le resto.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous soupirez en vous remémorant votre rencontre avec " + votre_femme + ".\n");
                                                                                                        Console.ReadKey();
                                                                                                        visiterét1 = true;
                                                                                                        goto resto;
                                                                                                    }
                                                                                                    break;

                                                                                                case "écriteau":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous vous approchez des portes pour lire l'écriteau.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("il est écrit Fermé.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("en dessous il y a les horraires d'ouverture du restaurant");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous soupirez");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous : il n'ouvre au public qu'après mes heures de travail.\n");
                                                                                                        Console.ReadKey();
                                                                                                        visiterét1 = true;
                                                                                                        goto resto;
                                                                                                    }
                                                                                                    break;

                                                                                                default:
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto resto;
                                                                                                    }
                                                                                                    break;

                                                                                            }
                                                                                        }
                                                                                        break;

                                                                                    case "2":
                                                                                        {
                                                                                            if (étageacctu == "2")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton 2.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au 2ièm étage.\n");
                                                                                                goto ascenseur;
                                                                                            }

                                                                                            Console.WriteLine("\nvous appuyez sur le bouton 2.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sentez l'ascenseur monter.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'ascenseur s'arrête au 2ièm étage.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "2";
                                                                                        salledereception:;
                                                                                            string choixmarri = " ";
                                                                                            Console.WriteLine("vous êtes devant une [salle] de réception.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("il y a l'[ascenseur] derrière vous.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("où voulez vous aller? : ");
                                                                                            choixmarri = Convert.ToString(Console.ReadLine());

                                                                                            switch (choixmarri)
                                                                                            {
                                                                                                case "ascenseur":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous appuyez sur le bouton de l'ascenseur.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les portes de l'ascenseur s'ouvrent\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto ascenseur;
                                                                                                    }
                                                                                                    break;

                                                                                                case "salle":
                                                                                                    {

                                                                                                        Console.WriteLine("\nvous vous approchez de la salle.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les tables et la décorations sont toutes blanches.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("la salle est pleine de gens.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("ils ont l'air de célébrer un marriage.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous soupirez avec nostalgie et tristesse.\n");
                                                                                                        Console.ReadKey();
                                                                                                        visiterét2 = true;
                                                                                                        goto salledereception;
                                                                                                    }
                                                                                                    break;

                                                                                                default:
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto salledereception;
                                                                                                    }
                                                                                                    break;
                                                                                            }
                                                                                        }
                                                                                        break;

                                                                                    case "3":
                                                                                        {
                                                                                            if (étageacctu == "3")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton 3.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au 3ièm étage.\n");
                                                                                                goto ascenseur;
                                                                                            }

                                                                                            Console.WriteLine("\nvous appuyez sur le bouton 3.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sentez l'ascenseur monter.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'ascenseur s'arrête au 3ièm étage.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "3";

                                                                                            string choixclinique = " ";
                                                                                            bool porte = false;
                                                                                            Console.WriteLine("vous êtes dans une clinique de naissances privée.");
                                                                                            Console.ReadKey();
                                                                                        clinique:;
                                                                                            Console.WriteLine("devant vous il y a les [portes] de la salle d'attente.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("un peu plus loing vous voyez une [vitre].");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous entendez des cries depuis une des [salles].");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("derrière vous il y a l'[ascenseur].");
                                                                                            Console.ReadKey();
                                                                                            Console.Write("où voulez vous allez? : ");
                                                                                            choixclinique = Convert.ToString(Console.ReadLine());

                                                                                            switch (choixclinique)
                                                                                            {
                                                                                                case "ascenseur":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous appuyez sur le bouton de l'ascenseur.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les portes de l'ascenseur s'ouvrent\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto ascenseur;
                                                                                                    }
                                                                                                    break;

                                                                                                case "salles":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous entrez dans la salle d'attente.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("elle est remplie de femmes enceintes qui attendent une consultation.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("votre attention est attiré par une femme qui attend sans son mari pour l'accompagner.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous sentez une pression sur votre torse.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous sortez de la salle d'attente\n");
                                                                                                        Console.ReadKey();
                                                                                                        visiterét3 = true;
                                                                                                        goto clinique;
                                                                                                    }
                                                                                                    break;

                                                                                                case "vitre":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous vous approcher de la grande vitre rectangulaire.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("de l'autre côté il y a la garderie de la clinique.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("tout les berceaux ont au moins un bébé et certains en ont deux.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("vous vous éloignez de la vitre.\n");
                                                                                                        Console.ReadKey();
                                                                                                        visiterét3 = true;
                                                                                                        goto clinique;
                                                                                                    }
                                                                                                    break;

                                                                                                case "portes":
                                                                                                    {
                                                                                                        if (porte == false)
                                                                                                        {
                                                                                                            Console.WriteLine("\nvous vous apprrochez de la salle d'où proviennent les cris.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("quand vous arrivez devant la porte de la salle vous voyez une femme qui acouche.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("un médecin vous voit et ferme la porte de la salle");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("vous entendez le médecin dire qu'il doit procéder à une césarienne.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("un frisson vous parcours le dos.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("vous retournez d'où vous venez.\n");
                                                                                                            Console.ReadKey();
                                                                                                            visiterét3 = true;
                                                                                                            porte = true;
                                                                                                            goto clinique;
                                                                                                        }

                                                                                                        else
                                                                                                        {
                                                                                                            Console.WriteLine("\nvous ne voyez pas d'intérêt à retourner là bas.\n");
                                                                                                            Console.ReadKey();
                                                                                                            goto clinique;
                                                                                                        }
                                                                                                    }
                                                                                                    break;

                                                                                                default:
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto clinique;
                                                                                                    }
                                                                                                    break;
                                                                                            }

                                                                                        }
                                                                                        break;

                                                                                    case "4":
                                                                                        {
                                                                                            if (étageacctu == "4")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton 4.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au 4ièm étage.\n");
                                                                                                goto ascenseur;
                                                                                            }

                                                                                            Console.WriteLine("\nvous appuyez sur le bouton 4.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sentez l'ascenseur monter.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'ascenseur s'arrête au 4ièm étage.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "4";

                                                                                            string choixretraite = " ";
                                                                                            bool parlersecr = false;
                                                                                            Console.WriteLine("vous êtes dans une maison de retraite.");
                                                                                            Console.ReadKey();
                                                                                        retraite:;
                                                                                            Console.WriteLine("vous voyez la [secrétaire] devant vous derrière sont bureau.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous avez l'[ascenseur] derrière vous.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("où voulez vous aller? : ");
                                                                                            choixretraite = Convert.ToString(Console.ReadLine());

                                                                                            switch (choixretraite)
                                                                                            {
                                                                                                case "ascenseur":
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous appuyez sur le bouton de l'ascenseur.");
                                                                                                        Console.ReadKey();
                                                                                                        Console.WriteLine("les portes de l'ascenseur s'ouvrent\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto ascenseur;

                                                                                                    }
                                                                                                    break;

                                                                                                case "secrétaire":
                                                                                                    {
                                                                                                        if (parlersecr == false)
                                                                                                        {
                                                                                                            Console.WriteLine("\nvous vous approchez du bureau de la secrétaire.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("elle vous dit bonjour et commence à vous décrire l'endroit.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("vous éccoutez à peine car vous êtes dans vos pensées.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("vous soupirez.");
                                                                                                            Console.ReadKey();
                                                                                                            Console.WriteLine("vous éprouvez du regret en vous éloignant du bureau de la secrétaire.\n");
                                                                                                            Console.ReadKey();
                                                                                                            visiterét4 = true;
                                                                                                            goto retraite;
                                                                                                        }

                                                                                                        else
                                                                                                        {
                                                                                                            Console.WriteLine("\nvous ne voyez pas l'intérêt de reparler à la secrétaire.\n");
                                                                                                            Console.ReadKey();
                                                                                                            goto retraite;
                                                                                                        }
                                                                                                    }
                                                                                                    break;

                                                                                                default:
                                                                                                    {
                                                                                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                                        Console.ReadKey();
                                                                                                        goto retraite;
                                                                                                    }
                                                                                                    break;
                                                                                            }
                                                                                        }
                                                                                        break;

                                                                                    case "5":
                                                                                        {
                                                                                            if (étageacctu == "5")
                                                                                            {
                                                                                                Console.WriteLine("\nvous appuyez sur le bouton 5.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("il ne se passe rien.");
                                                                                                Console.ReadKey();
                                                                                                Console.WriteLine("vous : je suis déja au 5ièm étage.\n");
                                                                                                goto ascenseur;
                                                                                            }

                                                                                            Console.WriteLine("\nvous appuyez sur le bouton 5.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sentez l'ascenseur monter.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("l'ascenseur s'arrête au 5ièm étage.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("les portes de l'ascenseur s'ouvrent.");
                                                                                            Console.ReadKey();
                                                                                            Console.WriteLine("vous sortez de l'ascenseur et les portes se referment derrière vous.\n");
                                                                                            Console.ReadKey();
                                                                                            étageacctu = "5";
                                                                                            goto pbureau;
                                                                                        }
                                                                                        break;

                                                                                    default:
                                                                                        {
                                                                                            Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                                            Console.ReadKey();
                                                                                            goto ascenseur;
                                                                                        }
                                                                                        break;

                                                                                }
                                                                            }

                                                                            else
                                                                            {
                                                                                Console.WriteLine("\nraté\n");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("...");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("...");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("...");
                                                                                Console.ReadKey();
                                                                                QTEascen = false;
                                                                                QTEascenf = true;
                                                                                branche_parking = true;
                                                                                goto ascenceurfail;
                                                                            }
                                                                        }

                                                                    }

                                                                }
                                                                break;

                                                            case "escalier":
                                                                {
                                                                    Console.WriteLine("vous ouvrez la porte des escaliers.");
                                                                    Console.ReadKey();
                                                                    Console.WriteLine("vous montez jusqu'au 5ièm étage où se trouve les bureaux de l'entreprise pour laquelle vous travaillez.");
                                                                    Console.ReadKey();
                                                                    branche_parking = true;
                                                                    goto pbureau;
                                                                }
                                                                break;

                                                            case "voiture":
                                                                {
                                                                    if (QTEfamdf == true)
                                                                    {
                                                                        if (QTEfamd == false)
                                                                        {
                                                                            if (contvoit == 3)
                                                                            {
                                                                                Console.Write("\nvous : JE ");
                                                                                Thread.Sleep(1500);
                                                                                Console.Write("DOIS ");
                                                                                Thread.Sleep(1500);
                                                                                Console.Write("ALLER ");
                                                                                Thread.Sleep(1500);
                                                                                Console.Write("TRAVAILLER!\n");
                                                                                contvoit = contvoit + 1;
                                                                                goto parking;
                                                                            }

                                                                            if (contvoit == 5)
                                                                            {
                                                                                Console.WriteLine("\n???? : tu sais que c'est la seul option.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("vous : non.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("???? : tu sais ce que nous leur avons fait.\n");
                                                                                Console.ReadKey();
                                                                                goto parking;
                                                                            }

                                                                            if (contvoit == 10)
                                                                            {
                                                                                int i = 0;
                                                                                Console.WriteLine("3");
                                                                                Thread.Sleep(1000);
                                                                                Console.WriteLine("2");
                                                                                Thread.Sleep(1000);
                                                                                Console.WriteLine("1");
                                                                                Thread.Sleep(1000);
                                                                                Console.WriteLine("[RÉSISTEZ]");
                                                                                DateTime datea = DateTime.Now;//enregistre l'heur avant le QTE
                                                                                do
                                                                                {
                                                                                    Console.ReadKey(); i++;
                                                                                } while (i < 10);//nombre de fois que l'utilisateur dois appuyer
                                                                                DateTime dateb = DateTime.Now;//enregistre l'heur apres le QTE
                                                                                Console.WriteLine("QTE terminé");
                                                                                Thread.Sleep(3000);//délai pour ne pas passer la suite de l'histoire
                                                                                TimeSpan res = dateb.Subtract(datea);//soustrait l'heur du début à l'heur de fin
                                                                                double resu = res.TotalSeconds;//converti le résultat en double en secondes
                                                                                Console.ReadKey();
                                                                                if (resu < 4)
                                                                                {
                                                                                    Console.WriteLine("\nréussi\n");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous reprenez vos esprits.");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous : il est vraiment temps d'aller travailler maintenant.\n");
                                                                                    Console.ReadKey();
                                                                                    goto parking;
                                                                                }
                                                                                else
                                                                                {
                                                                                    revientafAM = true;
                                                                                    Console.WriteLine("\nraté\n");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous craquez.");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous rentrez dans votre voiture.");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous démarrez la voiture, sortez du parking et rejoignez la route.\n");
                                                                                    revientafAM = true;
                                                                                    goto forêt;
                                                                                }
                                                                            }

                                                                            else
                                                                            {
                                                                                Console.WriteLine("\nvous : je dois aller travailler.\n");
                                                                                Console.ReadKey();
                                                                                contvoit = contvoit + 1;
                                                                                goto parking;
                                                                            }
                                                                        }

                                                                        if (QTEfamd == true)
                                                                        {
                                                                            if (contvoit == 3)
                                                                            {
                                                                                Console.Write("\nvous : JE ");
                                                                                Thread.Sleep(1500);
                                                                                Console.Write("DOIS ");
                                                                                Thread.Sleep(1500);
                                                                                Console.Write("ALLER ");
                                                                                Thread.Sleep(1500);
                                                                                Console.Write("TRAVAILLER!\n");
                                                                                contvoit = contvoit + 1;
                                                                                goto parking;
                                                                            }

                                                                            if (contvoit == 5)
                                                                            {
                                                                                Console.WriteLine("\n???? : tu savais que un jour ça allai arriver.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("vous : arrêt.");
                                                                                Console.ReadKey();
                                                                                Console.WriteLine("???? : tu sais ce que nous allions leur faire.\n");
                                                                                Console.ReadKey();
                                                                                contvoit = contvoit + 1;
                                                                                goto parking;
                                                                            }

                                                                            if (contvoit == 10)
                                                                            {
                                                                                int i = 0;
                                                                                Console.WriteLine("3");
                                                                                Thread.Sleep(1000);
                                                                                Console.WriteLine("2");
                                                                                Thread.Sleep(1000);
                                                                                Console.WriteLine("1");
                                                                                Thread.Sleep(1000);
                                                                                Console.WriteLine("[RÉSISTEZ]");
                                                                                DateTime datea = DateTime.Now;//enregistre l'heur avant le QTE
                                                                                do
                                                                                {
                                                                                    Console.ReadKey(); i++;
                                                                                } while (i < 10);//nombre de fois que l'utilisateur dois appuyer
                                                                                DateTime dateb = DateTime.Now;//enregistre l'heur apres le QTE
                                                                                Console.WriteLine("QTE terminé");
                                                                                Thread.Sleep(3000);//délai pour ne pas passer la suite de l'histoire
                                                                                TimeSpan res = dateb.Subtract(datea);//soustrait l'heur du début à l'heur de fin
                                                                                double resu = res.TotalSeconds;//converti le résultat en double en secondes
                                                                                Console.ReadKey();
                                                                                if (resu < 5)
                                                                                {
                                                                                    Console.WriteLine("\nréussi\n");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous reprenez vos esprits.");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous : il est vraiment temps d'aller travailler maintenant.\n");
                                                                                    Console.ReadKey();
                                                                                    goto parking;
                                                                                }
                                                                                else
                                                                                {
                                                                                    revientafAM = true;
                                                                                    Console.WriteLine("\nraté\n");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous craquez.");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous rentrez dans votre voiture.");
                                                                                    Console.ReadKey();
                                                                                    Console.WriteLine("vous démarrez la voiture, sortez du parking et rejoignez la route.\n");
                                                                                    revientafAM = true;
                                                                                    goto forêt;
                                                                                }
                                                                            }

                                                                            else
                                                                            {
                                                                                Console.WriteLine("\nvous : je dois aller travailler.\n");
                                                                                Console.ReadKey();
                                                                                contvoit = contvoit + 1;
                                                                                goto parking;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("\nvous : je dois aller travailler.\n");
                                                                            Console.ReadKey();
                                                                            goto parking;
                                                                        }
                                                                    }
                                                                }
                                                                break;

                                                            default:
                                                                {
                                                                    Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                                    Console.ReadKey();
                                                                    goto parking;
                                                                }
                                                                break;
                                                        }
                                                    }

                                                }
                                                break;

                                            default:
                                                {
                                                    Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                                    Console.ReadKey();
                                                    goto allerautaf;
                                                }
                                                break;
                                        }

                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("\nvous soupirez en étant confus, car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                                        Console.ReadKey();
                                        goto couloir;
                                    }
                                    break;
                            }

                        }
                    }
                    break;

                default:
                    {
                        Console.WriteLine("\nvous soupirez en étant confus car vous ne comprenez pas ce que votre cerveau essaye de vous faire faire.\n");
                        Console.ReadKey();
                        goto chambre;
                    }
                    break;
            }

        confin:;

            string fin = " ";
            Console.WriteLine("FIN");
            Console.ReadKey();//*************************************************** affichage de succès ************************************************************
            if (finpont = true && âme_sensible == false) { Console.WriteLine("\nsuccès débloqué (âme sensible) : débloquer la fin du pont."); nbdetropdécouverts = nbdetropdécouverts + 1; âme_sensible = true; }
            Thread.Sleep(500);
            if (visiterét1 == true && visiterét2 == true && visiterét3 == true && visiterét4 == true && nostalgie == false) { Console.WriteLine("\nsuccès débloqué (nostalgie) : avoir visité tout les étages du bâtiment au travail.\n"); nbdetropdécouverts = nbdetropdécouverts + 1; nostalgie = true; }
            Thread.Sleep(500);
            if (bain == true && rasoir == true && suicide == true && mort_avec_classe == false) { Console.WriteLine("\nsuccès débloqué (mort avec classe) : se raser, prendre un bain, mourrir."); nbdetropdécouverts = nbdetropdécouverts + 1; mort_avec_classe = true; }
            Thread.Sleep(500);
            if (mangerlapin == true && repas_mignon == false) { Console.WriteLine("\nsuccès débloqué (repas mignon) : un lapin? sérieusement?"); nbdetropdécouverts = nbdetropdécouverts + 1; repas_mignon = true; }
            Thread.Sleep(500);
            if (nbdetropdécouverts == nbdetroptotale) { Console.WriteLine("\nsuccès débloqué (100%) : finissez le jeu à 100% en débloquant toutes les fin et tous les succès"); }
            Thread.Sleep(500);
            Console.WriteLine("\nVous avez découvert " + nbdefindécouvertes + " / " + nbdefintotale + " fins.");
            Thread.Sleep(500);
            Console.WriteLine("\nVous avez débloqué " + nbdetropdécouverts + " / " + nbdetroptotale + " succès.");
            Console.ReadKey();//*************************************************** message de fin *****************************************************************
            Console.WriteLine("\n\n\n\nMerci d'avoir joué à la démo de mon premier jeu!!!!");// enlever et mettre les succès
            Console.ReadKey();
            Console.WriteLine("n'hésitez pas à me faire part de vos commentaires et à me demander la suite quand je l'aurai fini si vous avez appréciez cette démo.");//mettre un message d'accès anticipé.
            Console.ReadKey();
            Console.WriteLine("si vous même vous sentez triste quotidiennement ou si vous avez des idées suicidaire vous n'hésitez pas à aller chercher de l'aide ou appeler les numéros du site ci-dessous.");
            Console.WriteLine("https://www.infosuicide.org/urgences-aide-ressources/lignes-decoute/");
            Console.ReadKey();
            Console.WriteLine("\nvoulez vous [rejouer] ou [quitter] le jeu?\n");
            Console.ReadKey();
            Console.Write("choix : ");
            fin = Convert.ToString(Console.ReadLine());
            if (fin == "rejouer")
            {
                goto start;
            }
            if (fin == "quitter")
            {
                Console.WriteLine("\nmerci encore d'avoir joué au jeu\n");
                goto fin;
            }
            else
            {
                Console.WriteLine("\ndésoler ce n'est pas une option\n");
                Console.ReadKey();
                goto confin;
            }
        fin:;
            Console.ReadKey();
        }
    }
}