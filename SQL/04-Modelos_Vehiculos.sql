USE SisRent
GO

INSERT  INTO VehModelos
        ( IdModelo, IdMarca, Modelo )
VALUES  ( 1, 1, '500' ),
        ( 2, 1, 'Grande Punto' ),
        ( 3, 1, 'Punto Evo' ),
        ( 4, 1, '500c' ),
        ( 5, 1, '695' ),
        ( 6, 1, 'Punto' ),
        ( 7, 2, '155' ),
        ( 8, 2, '156' ),
        ( 9, 2, '159' ),
        ( 10, 2, '164' ),
        ( 11, 2, '145' ),
        ( 12, 2, '147' ),
        ( 13, 2, '146' ),
        ( 14, 2, 'Gtv' ),
        ( 15, 2, 'Spider' ),
        ( 16, 2, '166' ),
        ( 17, 2, 'Gt' ),
        ( 18, 2, 'Crosswagon' ),
        ( 19, 2, 'Brera' ),
        ( 20, 2, '90' ),
        ( 21, 2, '75' ),
        ( 22, 2, '33' ),
        ( 23, 2, 'Giulietta' ),
        ( 24, 2, 'Sprint' ),
        ( 25, 2, 'Mito' ),
        ( 26, 3, 'Expander' ),
        ( 27, 3, '10' ),
        ( 28, 3, '24' ),
        ( 29, 3, 'Dacia' ),
        ( 30, 4, 'Rocsta' ),
        ( 31, 5, 'Rocsta' ),
        ( 32, 6, 'Db7' ),
        ( 33, 6, 'V8' ),
        ( 34, 6, 'Db9' ),
        ( 35, 6, 'Vanquish' ),
        ( 36, 6, 'V8 Vantage' ),
        ( 37, 6, 'Vantage' ),
        ( 38, 6, 'Dbs' ),
        ( 39, 6, 'Volante' ),
        ( 40, 6, 'Virage' ),
        ( 41, 6, 'Vantage V8' ),
        ( 42, 6, 'Vantage V12' ),
        ( 43, 6, 'Rapide' ),
        ( 44, 6, 'Cygnet' ),
        ( 45, 7, '80' ),
        ( 46, 7, 'A4' ),
        ( 47, 7, 'A6' ),
        ( 48, 7, 'S6' ),
        ( 49, 7, 'Coupe' ),
        ( 50, 7, 'S2' ),
        ( 51, 7, 'Rs2' ),
        ( 52, 7, 'A8' ),
        ( 53, 7, 'Cabriolet' ),
        ( 54, 7, 'S8' ),
        ( 55, 7, 'A3' ),
        ( 56, 7, 'S4' ),
        ( 57, 7, 'Tt' ),
        ( 58, 7, 'S3' ),
        ( 59, 7, 'Allroad Quattro' ),
        ( 60, 7, 'Rs4' ),
        ( 61, 7, 'A2' ),
        ( 62, 7, 'Rs6' ),
        ( 63, 7, 'Q7' ),
        ( 64, 7, 'R8' ),
        ( 65, 7, 'A5' ),
        ( 66, 7, 'S5' ),
        ( 67, 7, 'V8' ),
        ( 68, 7, '200' ),
        ( 69, 7, '100' ),
        ( 70, 7, '90' ),
        ( 71, 7, 'Tts' ),
        ( 72, 7, 'Q5' ),
        ( 73, 7, 'A4 Allroad Quattro' ),
        ( 74, 7, 'Tt Rs' ),
        ( 75, 7, 'Rs5' ),
        ( 76, 7, 'A1' ),
        ( 77, 7, 'A7' ),
        ( 78, 7, 'Rs3' ),
        ( 79, 7, 'Q3' ),
        ( 80, 7, 'A6 Allroad Quattro' ),
        ( 81, 7, 'S7' ),
        ( 82, 7, 'Sq5' ),
        ( 83, 8, 'Mini' ),
        ( 84, 8, 'Montego' ),
        ( 85, 8, 'Maestro' ),
        ( 86, 8, 'Metro' ),
        ( 87, 8, 'Mini Moke' ),
        ( 88, 9, 'Diesel' ),
        ( 89, 10, 'Brooklands' ),
        ( 90, 10, 'Turbo' ),
        ( 91, 10, 'Continental' ),
        ( 92, 10, 'Azure' ),
        ( 93, 10, 'Arnage' ),
        ( 94, 10, 'Continental Gt' ),
        ( 95, 10, 'Continental Flying Spur' ),
        ( 96, 10, 'Turbo R' ),
        ( 97, 10, 'Mulsanne' ),
        ( 98, 10, 'Eight' ),
        ( 99, 10, 'Continental Gtc' ),
        ( 100, 10, 'Continental Supersports' ),
        ( 101, 11, 'Freeclimber Diesel' ),
        ( 102, 12, 'Serie 3' ),
        ( 103, 12, 'Serie 5' ),
        ( 104, 12, 'Compact' ),
        ( 105, 12, 'Serie 7' ),
        ( 106, 12, 'Serie 8' ),
        ( 107, 12, 'Z3' ),
        ( 108, 12, 'Z4' ),
        ( 109, 12, 'Z8' ),
        ( 110, 12, 'X5' ),
        ( 111, 12, 'Serie 6' ),
        ( 112, 12, 'X3' ),
        ( 113, 12, 'Serie 1' ),
        ( 114, 12, 'Z1' ),
        ( 115, 12, 'X6' ),
        ( 116, 12, 'X1' ),
        ( 117, 13, 'Seville' ),
        ( 118, 13, 'Sts' ),
        ( 119, 13, 'El Dorado' ),
        ( 120, 13, 'Cts' ),
        ( 121, 13, 'Xlr' ),
        ( 122, 13, 'Srx' ),
        ( 123, 13, 'Escalade' ),
        ( 124, 13, 'Bls' ),
        ( 125, 14, 'Corvette' ),
        ( 126, 14, 'Blazer' ),
        ( 127, 14, 'Astro' ),
        ( 128, 14, 'Nubira' ),
        ( 129, 14, 'Evanda' ),
        ( 130, 14, 'Trans Sport' ),
        ( 131, 14, 'Camaro' ),
        ( 132, 14, 'Matiz' ),
        ( 133, 14, 'Alero' ),
        ( 134, 14, 'Tahoe' ),
        ( 135, 14, 'Tacuma' ),
        ( 136, 14, 'Trailblazer' ),
        ( 137, 14, 'Kalos' ),
        ( 138, 14, 'Aveo' ),
        ( 139, 14, 'Lacetti' ),
        ( 140, 14, 'Epica' ),
        ( 141, 14, 'Captiva' ),
        ( 142, 14, 'Hhr' ),
        ( 143, 14, 'Cruze' ),
        ( 144, 14, 'Spark' ),
        ( 145, 14, 'Orlando' ),
        ( 146, 14, 'Volt' ),
        ( 147, 14, 'Malibu' ),
        ( 148, 15, 'Vision' ),
        ( 149, 15, '300m' ),
        ( 150, 15, 'Grand Voyager' ),
        ( 151, 15, 'Viper' ),
        ( 152, 15, 'Neon' ),
        ( 153, 15, 'Voyager' ),
        ( 154, 15, 'Stratus' ),
        ( 155, 15, 'Sebring' ),
        ( 156, 15, 'Sebring 200c' ),
        ( 157, 15, 'New Yorker' ),
        ( 158, 15, 'Pt Cruiser' ),
        ( 159, 15, 'Crossfire' ),
        ( 160, 15, '300c' ),
        ( 161, 15, 'Le Baron' ),
        ( 162, 15, 'Saratoga' ),
        ( 163, 16, 'Xantia' ),
        ( 164, 16, 'Xm' ),
        ( 165, 16, 'Ax' ),
        ( 166, 16, 'Zx' ),
        ( 167, 16, 'Evasion' ),
        ( 168, 16, 'C8' ),
        ( 169, 16, 'Saxo' ),
        ( 170, 16, 'C2' ),
        ( 171, 16, 'Xsara' ),
        ( 172, 16, 'C4' ),
        ( 173, 16, 'Xsara Picasso' ),
        ( 174, 16, 'C5' ),
        ( 175, 16, 'C3' ),
        ( 176, 16, 'C3 Pluriel' ),
        ( 177, 16, 'C1' ),
        ( 178, 16, 'C6' ),
        ( 179, 16, 'Grand C4 Picasso' ),
        ( 180, 16, 'C4 Picasso' ),
        ( 181, 16, 'Ccrosser' ),
        ( 182, 16, 'C15' ),
        ( 183, 16, 'Jumper' ),
        ( 184, 16, 'Jumpy' ),
        ( 185, 16, 'Berlingo' ),
        ( 186, 16, 'Bx' ),
        ( 187, 16, 'C25' ),
        ( 188, 16, 'Cx' ),
        ( 189, 16, 'Gsa' ),
        ( 190, 16, 'Visa' ),
        ( 191, 16, 'Lna' ),
        ( 192, 16, '2cv' ),
        ( 193, 16, 'Nemo' ),
        ( 194, 16, 'C4 Sedan' ),
        ( 195, 16, 'Berlingo First' ),
        ( 196, 16, 'C3 Picasso' ),
        ( 197, 16, 'Ds3' ),
        ( 198, 16, 'Czero' ),
        ( 199, 16, 'Ds4' ),
        ( 200, 16, 'Ds5' ),
        ( 201, 16, 'C4 Aircross' ),
        ( 202, 16, 'Celysee' ),
        ( 203, 17, 'Corvette' ),
        ( 204, 18, 'Contac' ),
        ( 205, 18, 'Logan' ),
        ( 206, 18, 'Sandero' ),
        ( 207, 18, 'Duster' ),
        ( 208, 18, 'Lodgy' ),
        ( 209, 19, 'Nexia' ),
        ( 210, 19, 'Aranos' ),
        ( 211, 19, 'Lanos' ),
        ( 212, 19, 'Nubira' ),
        ( 213, 19, 'Compact' ),
        ( 214, 19, 'Nubira Compact' ),
        ( 215, 19, 'Leganza' ),
        ( 216, 19, 'Evanda' ),
        ( 217, 19, 'Matiz' ),
        ( 218, 19, 'Tacuma' ),
        ( 219, 19, 'Kalos' ),
        ( 220, 19, 'Lacetti' ),
        ( 221, 21, 'Applause' ),
        ( 222, 21, 'Charade' ),
        ( 223, 21, 'Rocky' ),
        ( 224, 21, 'Feroza' ),
        ( 225, 21, 'Terios' ),
        ( 226, 21, 'Sirion' ),
        ( 227, 22, 'Serie Xj' ),
        ( 228, 22, 'Xj' ),
        ( 229, 22, 'Double Six' ),
        ( 230, 22, 'Six' ),
        ( 231, 22, 'Series Iii' ),
        ( 232, 23, 'Viper' ),
        ( 233, 23, 'Caliber' ),
        ( 234, 23, 'Nitro' ),
        ( 235, 23, 'Avenger' ),
        ( 236, 23, 'Journey' ),
        ( 237, 24, 'F355' ),
        ( 238, 24, '360' ),
        ( 239, 24, 'F430' ),
        ( 240, 24, 'F512 M' ),
        ( 241, 24, '550 Maranello' ),
        ( 242, 24, '575m Maranello' ),
        ( 243, 24, '599' ),
        ( 244, 24, '456' ),
        ( 245, 24, '456m' ),
        ( 246, 24, '612' ),
        ( 247, 24, 'F50' ),
        ( 248, 24, 'Enzo' ),
        ( 249, 24, 'Superamerica' ),
        ( 250, 24, '430' ),
        ( 251, 24, '348' ),
        ( 252, 24, 'Testarossa' ),
        ( 253, 24, '512' ),
        ( 254, 24, '355' ),
        ( 255, 24, 'F40' ),
        ( 256, 24, '412' ),
        ( 257, 24, 'Mondial' ),
        ( 258, 24, '328' ),
        ( 259, 24, 'California' ),
        ( 260, 24, '458' ),
        ( 261, 24, 'Ff' ),
        ( 262, 25, 'Croma' ),
        ( 263, 25, 'Cinquecento' ),
        ( 264, 25, 'Seicento' ),
        ( 265, 25, 'Punto' ),
        ( 266, 25, 'Grande Punto' ),
        ( 267, 25, 'Panda' ),
        ( 268, 25, 'Tipo' ),
        ( 269, 25, 'Coupe' ),
        ( 270, 25, 'Uno' ),
        ( 271, 25, 'Ulysse' ),
        ( 272, 25, 'Tempra' ),
        ( 273, 25, 'Marea' ),
        ( 274, 25, 'Barchetta' ),
        ( 275, 25, 'Bravo' ),
        ( 276, 25, 'Stilo' ),
        ( 277, 25, 'Brava' ),
        ( 278, 25, 'Palio Weekend' ),
        ( 279, 25, '600' ),
        ( 280, 25, 'Multipla' ),
        ( 281, 25, 'Idea' ),
        ( 282, 25, 'Sedici' ),
        ( 283, 25, 'Linea' ),
        ( 284, 25, '500' ),
        ( 285, 25, 'Fiorino' ),
        ( 286, 25, 'Ducato' ),
        ( 287, 25, 'Doblo Cargo' ),
        ( 288, 25, 'Doblo' ),
        ( 289, 25, 'Strada' ),
        ( 290, 25, 'Regata' ),
        ( 291, 25, 'Talento' ),
        ( 292, 25, 'Argenta' ),
        ( 293, 25, 'Ritmo' ),
        ( 294, 25, 'Punto Classic' ),
        ( 295, 25, 'Qubo' ),
        ( 296, 25, 'Punto Evo' ),
        ( 297, 25, '500c' ),
        ( 298, 25, 'Freemont' ),
        ( 299, 25, 'Panda Classic' ),
        ( 300, 25, '500l' ),
        ( 301, 26, 'Maverick' ),
        ( 302, 26, 'Escort' ),
        ( 303, 26, 'Focus' ),
        ( 304, 26, 'Mondeo' ),
        ( 305, 26, 'Scorpio' ),
        ( 306, 26, 'Fiesta' ),
        ( 307, 26, 'Probe' ),
        ( 308, 26, 'Explorer' ),
        ( 309, 26, 'Galaxy' ),
        ( 310, 26, 'Ka' ),
        ( 311, 26, 'Puma' ),
        ( 312, 26, 'Cougar' ),
        ( 313, 26, 'Focus Cmax' ),
        ( 314, 26, 'Fusion' ),
        ( 315, 26, 'Streetka' ),
        ( 316, 26, 'Cmax' ),
        ( 317, 26, 'Smax' ),
        ( 318, 26, 'Transit' ),
        ( 319, 26, 'Courier' ),
        ( 320, 26, 'Ranger' ),
        ( 321, 26, 'Sierra' ),
        ( 322, 26, 'Orion' ),
        ( 323, 26, 'Pick Up' ),
        ( 324, 26, 'Capri' ),
        ( 325, 26, 'Granada' ),
        ( 326, 26, 'Kuga' ),
        ( 327, 26, 'Grand Cmax' ),
        ( 328, 26, 'Bmax' ),
        ( 329, 26, 'Tourneo Custom' ),
        ( 330, 27, 'Exceed' ),
        ( 331, 27, 'Santamo' ),
        ( 332, 27, 'Super Exceed' ),
        ( 333, 29, 'Accord' ),
        ( 334, 29, 'Civic' ),
        ( 335, 29, 'Crx' ),
        ( 336, 29, 'Prelude' ),
        ( 337, 29, 'Nsx' ),
        ( 338, 29, 'Legend' ),
        ( 339, 29, 'Crv' ),
        ( 340, 29, 'Hrv' ),
        ( 341, 29, 'Logo' ),
        ( 342, 29, 'S2000' ),
        ( 343, 29, 'Stream' ),
        ( 344, 29, 'Jazz' ),
        ( 345, 29, 'Frv' ),
        ( 346, 29, 'Concerto' ),
        ( 347, 29, 'Insight' ),
        ( 348, 29, 'Crz' ),
        ( 349, 30, 'H2' ),
        ( 350, 30, 'H3' ),
        ( 351, 30, 'H3t' ),
        ( 352, 31, 'Lantra' ),
        ( 353, 31, 'Sonata' ),
        ( 354, 31, 'Elantra' ),
        ( 355, 31, 'Accent' ),
        ( 356, 31, 'Scoupe' ),
        ( 357, 31, 'Coupe' ),
        ( 358, 31, 'Atos' ),
        ( 359, 31, 'H1' ),
        ( 360, 31, 'Atos Prime' ),
        ( 361, 31, 'Xg' ),
        ( 362, 31, 'Trajet' ),
        ( 363, 31, 'Santa Fe' ),
        ( 364, 31, 'Terracan' ),
        ( 365, 31, 'Matrix' ),
        ( 366, 31, 'Getz' ),
        ( 367, 31, 'Tucson' ),
        ( 368, 31, 'I30' ),
        ( 369, 31, 'Pony' ),
        ( 370, 31, 'Grandeur' ),
        ( 371, 31, 'I10' ),
        ( 372, 31, 'I800' ),
        ( 373, 31, 'Sonata Fl' ),
        ( 374, 31, 'Ix55' ),
        ( 375, 31, 'I20' ),
        ( 376, 31, 'Ix35' ),
        ( 377, 31, 'Ix20' ),
        ( 378, 31, 'Genesis' ),
        ( 379, 31, 'I40' ),
        ( 380, 31, 'Veloster' ),
        ( 381, 32, 'G' ),
        ( 382, 32, 'Ex' ),
        ( 383, 32, 'Fx' ),
        ( 384, 32, 'M' ),
        ( 385, 33, 'Elba' ),
        ( 386, 33, 'Minitre' ),
        ( 387, 34, 'Trooper' ),
        ( 388, 34, 'Pick Up' ),
        ( 389, 34, 'D Max' ),
        ( 390, 34, 'Rodeo' ),
        ( 391, 34, 'Dmax' ),
        ( 392, 34, 'Trroper' ),
        ( 393, 35, 'Daily' ),
        ( 394, 35, 'Massif' ),
        ( 395, 36, 'Daily' ),
        ( 396, 36, 'Duty' ),
        ( 397, 37, 'Serie Xj' ),
        ( 398, 37, 'Serie Xk' ),
        ( 399, 37, 'Xj' ),
        ( 400, 37, 'Stype' ),
        ( 401, 37, 'Xf' ),
        ( 402, 37, 'Xtype' ),
        ( 403, 38, 'Wrangler' ),
        ( 404, 38, 'Cherokee' ),
        ( 405, 38, 'Grand Cherokee' ),
        ( 406, 38, 'Commander' ),
        ( 407, 38, 'Compass' ),
        ( 408, 38, 'Wrangler Unlimited' ),
        ( 409, 38, 'Patriot' ),
        ( 410, 39, 'Sportage' ),
        ( 411, 39, 'Sephia' ),
        ( 412, 39, 'Sephia Ii' ),
        ( 413, 39, 'Pride' ),
        ( 414, 39, 'Clarus' ),
        ( 415, 39, 'Shuma' ),
        ( 416, 39, 'Carnival' ),
        ( 417, 39, 'Joice' ),
        ( 418, 39, 'Magentis' ),
        ( 419, 39, 'Carens' ),
        ( 420, 39, 'Rio' ),
        ( 421, 39, 'Cerato' ),
        ( 422, 39, 'Sorento' ),
        ( 423, 39, 'Opirus' ),
        ( 424, 39, 'Picanto' ),
        ( 425, 39, 'Ceed' ),
        ( 426, 39, 'Ceed Sporty Wagon' ),
        ( 427, 39, 'Proceed' ),
        ( 428, 39, 'K2500 Frontier' ),
        ( 429, 39, 'K2500' ),
        ( 430, 39, 'Soul' ),
        ( 431, 39, 'Venga' ),
        ( 432, 39, 'Optima' ),
        ( 433, 39, 'Ceed Sportswagon' ),
        ( 434, 40, 'Samara' ),
        ( 435, 40, 'Niva' ),
        ( 436, 40, 'Sagona' ),
        ( 437, 40, 'Stawra 2110' ),
        ( 438, 40, '214' ),
        ( 439, 40, 'Kalina' ),
        ( 440, 40, 'Serie 2100' ),
        ( 441, 40, 'Priora' ),
        ( 442, 41, 'Gallardo' ),
        ( 443, 41, 'Murcielago' ),
        ( 444, 41, 'Aventador' ),
        ( 445, 42, 'Delta' ),
        ( 446, 42, 'K' ),
        ( 447, 42, 'Y10' ),
        ( 448, 42, 'Dedra' ),
        ( 449, 42, 'Lybra' ),
        ( 450, 42, 'Z' ),
        ( 451, 42, 'Y' ),
        ( 452, 42, 'Ypsilon' ),
        ( 453, 42, 'Thesis' ),
        ( 454, 42, 'Phedra' ),
        ( 455, 42, 'Musa' ),
        ( 456, 42, 'Thema' ),
        ( 457, 42, 'Zeta' ),
        ( 458, 42, 'Kappa' ),
        ( 459, 42, 'Trevi' ),
        ( 460, 42, 'Prisma' ),
        ( 461, 42, 'A112' ),
        ( 462, 42, 'Ypsilon Elefantino' ),
        ( 463, 42, 'Voyager' ),
        ( 464, 43, 'Range Rover' ),
        ( 465, 43, 'Defender' ),
        ( 466, 43, 'Discovery' ),
        ( 467, 43, 'Freelander' ),
        ( 468, 43, 'Range Rover Sport' ),
        ( 469, 43, 'Discovery 4' ),
        ( 470, 43, 'Range Rover Evoque' ),
        ( 471, 44, 'Maxus' ),
        ( 472, 45, 'Ls400' ),
        ( 473, 45, 'Ls430' ),
        ( 474, 45, 'Gs300' ),
        ( 475, 45, 'Is200' ),
        ( 476, 45, 'Rx300' ),
        ( 477, 45, 'Gs430' ),
        ( 478, 45, 'Gs460' ),
        ( 479, 45, 'Sc430' ),
        ( 480, 45, 'Is300' ),
        ( 481, 45, 'Is250' ),
        ( 482, 45, 'Rx400h' ),
        ( 483, 45, 'Is220d' ),
        ( 484, 45, 'Rx350' ),
        ( 485, 45, 'Gs450h' ),
        ( 486, 45, 'Ls460' ),
        ( 487, 45, 'Ls600h' ),
        ( 488, 45, 'Ls' ),
        ( 489, 45, 'Gs' ),
        ( 490, 45, 'Is' ),
        ( 491, 45, 'Sc' ),
        ( 492, 45, 'Rx' ),
        ( 493, 45, 'Ct' ),
        ( 494, 46, 'Elise' ),
        ( 495, 46, 'Exige' ),
        ( 496, 47, 'Bolero Pickup' ),
        ( 497, 47, 'Goa Pickup' ),
        ( 498, 47, 'Goa' ),
        ( 499, 47, 'Cj' ),
        ( 500, 47, 'Pikup' ),
        ( 501, 47, 'Thar' ),
        ( 502, 48, 'Ghibli' ),
        ( 503, 48, 'Shamal' ),
        ( 504, 48, 'Quattroporte' ),
        ( 505, 48, '3200 Gt' ),
        ( 506, 48, 'Coupe' ),
        ( 507, 48, 'Spyder' ),
        ( 508, 48, 'Gransport' ),
        ( 509, 48, 'Granturismo' ),
        ( 510, 48, '430' ),
        ( 511, 48, 'Biturbo' ),
        ( 512, 48, '228' ),
        ( 513, 48, '224' ),
        ( 514, 48, 'Grancabrio' ),
        ( 515, 49, 'Maybach' ),
        ( 516, 50, 'Xedos 6' ),
        ( 517, 50, '626' ),
        ( 518, 50, '121' ),
        ( 519, 50, 'Xedos 9' ),
        ( 520, 50, '323' ),
        ( 521, 50, 'Mx3' ),
        ( 522, 50, 'Rx7' ),
        ( 523, 50, 'Mx5' ),
        ( 524, 50, 'Mazda3' ),
        ( 525, 50, 'Mpv' ),
        ( 526, 50, 'Demio' ),
        ( 527, 50, 'Premacy' ),
        ( 528, 50, 'Tribute' ),
        ( 529, 50, 'Mazda6' ),
        ( 530, 50, 'Mazda2' ),
        ( 531, 50, 'Rx8' ),
        ( 532, 50, 'Mazda5' ),
        ( 533, 50, 'Cx7' ),
        ( 534, 50, 'Serie B' ),
        ( 535, 50, 'B2500' ),
        ( 536, 50, 'Bt50' ),
        ( 537, 50, 'Mx6' ),
        ( 538, 50, '929' ),
        ( 539, 50, 'Cx5' ),
        ( 540, 51, 'Clase C' ),
        ( 541, 51, 'Clase E' ),
        ( 542, 51, 'Clase Sl' ),
        ( 543, 51, 'Clase S' ),
        ( 544, 51, 'Clase Cl' ),
        ( 545, 51, 'Clase G' ),
        ( 546, 51, 'Clase Slk' ),
        ( 547, 51, 'Clase V' ),
        ( 548, 51, 'Viano' ),
        ( 549, 51, 'Clase Clk' ),
        ( 550, 51, 'Clase A' ),
        ( 551, 51, 'Clase M' ),
        ( 552, 51, 'Vaneo' ),
        ( 553, 51, 'Slklasse' ),
        ( 554, 51, 'Slr Mclaren' ),
        ( 555, 51, 'Clase Cls' ),
        ( 556, 51, 'Clase R' ),
        ( 557, 51, 'Clase Gl' ),
        ( 558, 51, 'Clase B' ),
        ( 559, 51, '100d' ),
        ( 560, 51, '140d' ),
        ( 561, 51, '180d' ),
        ( 562, 51, 'Sprinter' ),
        ( 563, 51, 'Vito' ),
        ( 564, 51, 'Transporter' ),
        ( 565, 51, '280' ),
        ( 566, 51, '220' ),
        ( 567, 51, '200' ),
        ( 568, 51, '190' ),
        ( 569, 51, '600' ),
        ( 570, 51, '400' ),
        ( 571, 51, 'Clase Sl R129' ),
        ( 572, 51, '300' ),
        ( 573, 51, '500' ),
        ( 574, 51, '420' ),
        ( 575, 51, '260' ),
        ( 576, 51, '230' ),
        ( 577, 51, 'Clase Clc' ),
        ( 578, 51, 'Clase Glk' ),
        ( 579, 51, 'Sls Amg' ),
        ( 580, 52, 'Mgf' ),
        ( 581, 52, 'Tf' ),
        ( 582, 52, 'Zr' ),
        ( 583, 52, 'Zs' ),
        ( 584, 52, 'Zt' ),
        ( 585, 52, 'Ztt' ),
        ( 586, 52, 'Mini' ),
        ( 587, 52, 'Countryman' ),
        ( 588, 52, 'Paceman' ),
        ( 589, 54, 'Montero' ),
        ( 590, 54, 'Galant' ),
        ( 591, 54, 'Colt' ),
        ( 592, 54, 'Space Wagon' ),
        ( 593, 54, 'Space Runner' ),
        ( 594, 54, 'Space Gear' ),
        ( 595, 54, '3000 Gt' ),
        ( 596, 54, 'Carisma' ),
        ( 597, 54, 'Eclipse' ),
        ( 598, 54, 'Space Star' ),
        ( 599, 54, 'Montero Sport' ),
        ( 600, 54, 'Montero Io' ),
        ( 601, 54, 'Outlander' ),
        ( 602, 54, 'Lancer' ),
        ( 603, 54, 'Grandis' ),
        ( 604, 54, 'L200' ),
        ( 605, 54, 'Canter' ),
        ( 606, 54, '300 Gt' ),
        ( 607, 54, 'Asx' ),
        ( 608, 54, 'Imiev' ),
        ( 609, 55, '44' ),
        ( 610, 55, 'Plus 8' ),
        ( 611, 55, 'Aero 8' ),
        ( 612, 55, 'V6' ),
        ( 613, 55, 'Roadster' ),
        ( 614, 55, '4' ),
        ( 615, 55, 'Plus 4' ),
        ( 616, 56, 'Terrano Ii' ),
        ( 617, 56, 'Terrano' ),
        ( 618, 56, 'Micra' ),
        ( 619, 56, 'Sunny' ),
        ( 620, 56, 'Primera' ),
        ( 621, 56, 'Serena' ),
        ( 622, 56, 'Patrol' ),
        ( 623, 56, 'Maxima Qx' ),
        ( 624, 56, '200 Sx' ),
        ( 625, 56, '300 Zx' ),
        ( 626, 56, 'Patrol Gr' ),
        ( 627, 56, '100 Nx' ),
        ( 628, 56, 'Almera' ),
        ( 629, 56, 'Pathfinder' ),
        ( 630, 56, 'Almera Tino' ),
        ( 631, 56, 'Xtrail' ),
        ( 632, 56, '350z' ),
        ( 633, 56, 'Murano' ),
        ( 634, 56, 'Note' ),
        ( 635, 56, 'Qashqai' ),
        ( 636, 56, 'Tiida' ),
        ( 637, 56, 'Vanette' ),
        ( 638, 56, 'Trade' ),
        ( 639, 56, 'Vanette Cargo' ),
        ( 640, 56, 'Pickup' ),
        ( 641, 56, 'Navara' ),
        ( 642, 56, 'Cabstar E' ),
        ( 643, 56, 'Cabstar' ),
        ( 644, 56, 'Maxima' ),
        ( 645, 56, 'Camion' ),
        ( 646, 56, 'Prairie' ),
        ( 647, 56, 'Bluebird' ),
        ( 648, 56, 'Np300 Pick Up' ),
        ( 649, 56, 'Qashqai2' ),
        ( 650, 56, 'Pixo' ),
        ( 651, 56, 'Gtr' ),
        ( 652, 56, '370z' ),
        ( 653, 56, 'Cube' ),
        ( 654, 56, 'Juke' ),
        ( 655, 56, 'Leaf' ),
        ( 656, 56, 'Evalia' ),
        ( 657, 57, 'Astra' ),
        ( 658, 57, 'Vectra' ),
        ( 659, 57, 'Calibra' ),
        ( 660, 57, 'Corsa' ),
        ( 661, 57, 'Omega' ),
        ( 662, 57, 'Frontera' ),
        ( 663, 57, 'Tigra' ),
        ( 664, 57, 'Monterey' ),
        ( 665, 57, 'Sintra' ),
        ( 666, 57, 'Zafira' ),
        ( 667, 57, 'Agila' ),
        ( 668, 57, 'Speedster' ),
        ( 669, 57, 'Signum' ),
        ( 670, 57, 'Meriva' ),
        ( 671, 57, 'Antara' ),
        ( 672, 57, 'Gt' ),
        ( 673, 57, 'Combo' ),
        ( 674, 57, 'Movano' ),
        ( 675, 57, 'Vivaro' ),
        ( 676, 57, 'Kadett' ),
        ( 677, 57, 'Monza' ),
        ( 678, 57, 'Senator' ),
        ( 679, 57, 'Rekord' ),
        ( 680, 57, 'Manta' ),
        ( 681, 57, 'Ascona' ),
        ( 682, 57, 'Insignia' ),
        ( 683, 57, 'Zafira Tourer' ),
        ( 684, 57, 'Ampera' ),
        ( 685, 57, 'Mokka' ),
        ( 686, 57, 'Adam' ),
        ( 687, 58, '306' ),
        ( 688, 58, '605' ),
        ( 689, 58, '106' ),
        ( 690, 58, '205' ),
        ( 691, 58, '405' ),
        ( 692, 58, '406' ),
        ( 693, 58, '806' ),
        ( 694, 58, '807' ),
        ( 695, 58, '407' ),
        ( 696, 58, '307' ),
        ( 697, 58, '206' ),
        ( 698, 58, '607' ),
        ( 699, 58, '308' ),
        ( 700, 58, '307 Sw' ),
        ( 701, 58, '206 Sw' ),
        ( 702, 58, '407 Sw' ),
        ( 703, 58, '1007' ),
        ( 704, 58, '107' ),
        ( 705, 58, '207' ),
        ( 706, 58, '4007' ),
        ( 707, 58, 'Boxer' ),
        ( 708, 58, 'Partner' ),
        ( 709, 58, 'J5' ),
        ( 710, 58, '604' ),
        ( 711, 58, '505' ),
        ( 712, 58, '309' ),
        ( 713, 58, 'Bipper' ),
        ( 714, 58, 'Partner Origin' ),
        ( 715, 58, '3008' ),
        ( 716, 58, '5008' ),
        ( 717, 58, 'Rcz' ),
        ( 718, 58, '508' ),
        ( 719, 58, 'Ion' ),
        ( 720, 58, '208' ),
        ( 721, 58, '4008' ),
        ( 722, 59, 'Trans Sport' ),
        ( 723, 59, 'Firebird' ),
        ( 724, 59, 'Trans Am' ),
        ( 725, 60, '911' ),
        ( 726, 60, 'Boxster' ),
        ( 727, 60, 'Cayenne' ),
        ( 728, 60, 'Carrera Gt' ),
        ( 729, 60, 'Cayman' ),
        ( 730, 60, '928' ),
        ( 731, 60, '968' ),
        ( 732, 60, '944' ),
        ( 733, 60, '924' ),
        ( 734, 60, 'Panamera' ),
        ( 735, 60, '918' ),
        ( 736, 61, 'Megane' ),
        ( 737, 61, 'Safrane' ),
        ( 738, 61, 'Laguna' ),
        ( 739, 61, 'Clio' ),
        ( 740, 61, 'Twingo' ),
        ( 741, 61, 'Nevada' ),
        ( 742, 61, 'Espace' ),
        ( 743, 61, 'Spider' ),
        ( 744, 61, 'Scenic' ),
        ( 745, 61, 'Grand Espace' ),
        ( 746, 61, 'Avantime' ),
        ( 747, 61, 'Vel Satis' ),
        ( 748, 61, 'Grand Scenic' ),
        ( 749, 61, 'Clio Campus' ),
        ( 750, 61, 'Modus' ),
        ( 751, 61, 'Express' ),
        ( 752, 61, 'Trafic' ),
        ( 753, 61, 'Master' ),
        ( 754, 61, 'Kangoo' ),
        ( 755, 61, 'Mascott' ),
        ( 756, 61, 'Master Propulsion' ),
        ( 757, 61, 'Maxity' ),
        ( 758, 61, 'R19' ),
        ( 759, 61, 'R25' ),
        ( 760, 61, 'R5' ),
        ( 761, 61, 'R21' ),
        ( 762, 61, 'R4' ),
        ( 763, 61, 'Alpine' ),
        ( 764, 61, 'Fuego' ),
        ( 765, 61, 'R18' ),
        ( 766, 61, 'R11' ),
        ( 767, 61, 'R9' ),
        ( 768, 61, 'R6' ),
        ( 769, 61, 'Grand Modus' ),
        ( 770, 61, 'Kangoo Combi' ),
        ( 771, 61, 'Koleos' ),
        ( 772, 61, 'Fluence' ),
        ( 773, 61, 'Wind' ),
        ( 774, 61, 'Latitude' ),
        ( 775, 61, 'Grand Kangoo Combi' ),
        ( 776, 62, 'Siver Dawn' ),
        ( 777, 62, 'Silver Spur' ),
        ( 778, 62, 'Park Ward' ),
        ( 779, 62, 'Silver Seraph' ),
        ( 780, 62, 'Corniche' ),
        ( 781, 62, 'Phantom' ),
        ( 782, 62, 'Touring' ),
        ( 783, 62, 'Silvier' ),
        ( 784, 63, '800' ),
        ( 785, 63, '600' ),
        ( 786, 63, '100' ),
        ( 787, 63, '200' ),
        ( 788, 63, 'Coupe' ),
        ( 789, 63, '400' ),
        ( 790, 63, '45' ),
        ( 791, 63, 'Cabriolet' ),
        ( 792, 63, '25' ),
        ( 793, 63, 'Mini' ),
        ( 794, 63, '75' ),
        ( 795, 63, 'Streetwise' ),
        ( 796, 63, 'Sd' ),
        ( 797, 64, '900' ),
        ( 798, 64, '93' ),
        ( 799, 64, '9000' ),
        ( 800, 64, '95' ),
        ( 801, 64, '93x' ),
        ( 802, 64, '94x' ),
        ( 803, 65, '300' ),
        ( 804, 65, '350' ),
        ( 805, 65, 'Anibal' ),
        ( 806, 65, 'Anibal Pick Up' ),
        ( 807, 66, 'Ibiza' ),
        ( 808, 66, 'Cordoba' ),
        ( 809, 66, 'Toledo' ),
        ( 810, 66, 'Marbella' ),
        ( 811, 66, 'Alhambra' ),
        ( 812, 66, 'Arosa' ),
        ( 813, 66, 'Leon' ),
        ( 814, 66, 'Altea' ),
        ( 815, 66, 'Altea Xl' ),
        ( 816, 66, 'Altea Freetrack' ),
        ( 817, 66, 'Terra' ),
        ( 818, 66, 'Inca' ),
        ( 819, 66, 'Malaga' ),
        ( 820, 66, 'Ronda' ),
        ( 821, 66, 'Exeo' ),
        ( 822, 66, 'Mii' ),
        ( 823, 67, 'Felicia' ),
        ( 824, 67, 'Forman' ),
        ( 825, 67, 'Octavia' ),
        ( 826, 67, 'Octavia Tour' ),
        ( 827, 67, 'Fabia' ),
        ( 828, 67, 'Superb' ),
        ( 829, 67, 'Roomster' ),
        ( 830, 67, 'Scout' ),
        ( 831, 67, 'Pickup' ),
        ( 832, 67, 'Favorit' ),
        ( 833, 67, '130' ),
        ( 834, 67, 'S' ),
        ( 835, 67, 'Yeti' ),
        ( 836, 67, 'Citigo' ),
        ( 837, 67, 'Rapid' ),
        ( 838, 68, 'Smart' ),
        ( 839, 68, 'Citycoupe' ),
        ( 840, 68, 'Fortwo' ),
        ( 841, 68, 'Cabrio' ),
        ( 842, 68, 'Crossblade' ),
        ( 843, 68, 'Roadster' ),
        ( 844, 68, 'Forfour' ),
        ( 845, 69, 'Korando' ),
        ( 846, 69, 'Family' ),
        ( 847, 69, 'K4d' ),
        ( 848, 69, 'Musso' ),
        ( 849, 69, 'Korando Kj' ),
        ( 850, 69, 'Rexton' ),
        ( 851, 69, 'Rexton Ii' ),
        ( 852, 69, 'Rodius' ),
        ( 853, 69, 'Kyron' ),
        ( 854, 69, 'Actyon' ),
        ( 855, 69, 'Sports Pick Up' ),
        ( 856, 69, 'Actyon Sports Pick Up' ),
        ( 857, 69, 'Kodando' ),
        ( 858, 70, 'Legacy' ),
        ( 859, 70, 'Impreza' ),
        ( 860, 70, 'Svx' ),
        ( 861, 70, 'Justy' ),
        ( 862, 70, 'Outback' ),
        ( 863, 70, 'Forester' ),
        ( 864, 70, 'G3x Justy' ),
        ( 865, 70, 'B9 Tribeca' ),
        ( 866, 70, 'Xt' ),
        ( 867, 70, '1800' ),
        ( 868, 70, 'Tribeca' ),
        ( 869, 70, 'Wrx Sti' ),
        ( 870, 70, 'Trezia' ),
        ( 871, 70, 'Xv' ),
        ( 872, 70, 'Brz' ),
        ( 873, 71, 'Maruti' ),
        ( 874, 71, 'Swift' ),
        ( 875, 71, 'Vitara' ),
        ( 876, 71, 'Baleno' ),
        ( 877, 71, 'Samurai' ),
        ( 878, 71, 'Alto' ),
        ( 879, 71, 'Wagon R' ),
        ( 880, 71, 'Jimny' ),
        ( 881, 71, 'Grand Vitara' ),
        ( 882, 71, 'Ignis' ),
        ( 883, 71, 'Liana' ),
        ( 884, 71, 'Grand Vitara Xl7' ),
        ( 885, 71, 'Sx4' ),
        ( 886, 71, 'Splash' ),
        ( 887, 71, 'Kizashi' ),
        ( 888, 72, 'Samba' ),
        ( 889, 72, 'Tagora' ),
        ( 890, 72, 'Solara' ),
        ( 891, 72, 'Horizon' ),
        ( 892, 73, 'Telcosport' ),
        ( 893, 73, 'Telco' ),
        ( 894, 73, 'Sumo' ),
        ( 895, 73, 'Safari' ),
        ( 896, 73, 'Indica' ),
        ( 897, 73, 'Indigo' ),
        ( 898, 73, 'Grand Safari' ),
        ( 899, 73, 'Tl Pick Up' ),
        ( 900, 73, 'Xenon Pick Up' ),
        ( 901, 73, 'Vista' ),
        ( 902, 73, 'Xenon' ),
        ( 903, 73, 'Aria' ),
        ( 904, 74, 'Carina E' ),
        ( 905, 74, '4runner' ),
        ( 906, 74, 'Camry' ),
        ( 907, 74, 'Rav4' ),
        ( 908, 74, 'Celica' ),
        ( 909, 74, 'Supra' ),
        ( 910, 74, 'Paseo' ),
        ( 911, 74, 'Land Cruiser 80' ),
        ( 912, 74, 'Land Cruiser 100' ),
        ( 913, 74, 'Land Cruiser' ),
        ( 914, 74, 'Land Cruiser 90' ),
        ( 915, 74, 'Corolla' ),
        ( 916, 74, 'Auris' ),
        ( 917, 74, 'Avensis' ),
        ( 918, 74, 'Picnic' ),
        ( 919, 74, 'Yaris' ),
        ( 920, 74, 'Yaris Verso' ),
        ( 921, 74, 'Mr2' ),
        ( 922, 74, 'Previa' ),
        ( 923, 74, 'Prius' ),
        ( 924, 74, 'Avensis Verso' ),
        ( 925, 74, 'Corolla Verso' ),
        ( 926, 74, 'Corolla Sedan' ),
        ( 927, 74, 'Aygo' ),
        ( 928, 74, 'Hilux' ),
        ( 929, 74, 'Dyna' ),
        ( 930, 74, 'Land Cruiser 200' ),
        ( 931, 74, 'Verso' ),
        ( 932, 74, 'Iq' ),
        ( 933, 74, 'Urban Cruiser' ),
        ( 934, 74, 'Gt86' ),
        ( 935, 75, '100' ),
        ( 936, 75, '121' ),
        ( 937, 76, '214' ),
        ( 938, 76, '110 Stawra' ),
        ( 939, 76, '111 Stawra' ),
        ( 940, 76, '215' ),
        ( 941, 76, '112 Stawra' ),
        ( 942, 77, 'Passat' ),
        ( 943, 77, 'Golf' ),
        ( 944, 77, 'Vento' ),
        ( 945, 77, 'Polo' ),
        ( 946, 77, 'Corrado' ),
        ( 947, 77, 'Sharan' ),
        ( 948, 77, 'Lupo' ),
        ( 949, 77, 'Bora' ),
        ( 950, 77, 'Jetta' ),
        ( 951, 77, 'New Beetle' ),
        ( 952, 77, 'Phaeton' ),
        ( 953, 77, 'Touareg' ),
        ( 954, 77, 'Touran' ),
        ( 955, 77, 'Multivan' ),
        ( 956, 77, 'Caddy' ),
        ( 957, 77, 'Golf Plus' ),
        ( 958, 77, 'Fox' ),
        ( 959, 77, 'Eos' ),
        ( 960, 77, 'Caravelle' ),
        ( 961, 77, 'Tiguan' ),
        ( 962, 77, 'Transporter' ),
        ( 963, 77, 'Lt' ),
        ( 964, 77, 'Taro' ),
        ( 965, 77, 'Crafter' ),
        ( 966, 77, 'California' ),
        ( 967, 77, 'Santana' ),
        ( 968, 77, 'Scirocco' ),
        ( 969, 77, 'Passat Cc' ),
        ( 970, 77, 'Amarok' ),
        ( 971, 77, 'Beetle' ),
        ( 972, 77, 'Up' ),
        ( 973, 77, 'Cc' ),
        ( 974, 78, '440' ),
        ( 975, 78, '850' ),
        ( 976, 78, 'S70' ),
        ( 977, 78, 'V70' ),
        ( 978, 78, 'V70 Classic' ),
        ( 979, 78, '940' ),
        ( 980, 78, '480' ),
        ( 981, 78, '460' ),
        ( 982, 78, '960' ),
        ( 983, 78, 'S90' ),
        ( 984, 78, 'V90' ),
        ( 985, 78, 'Classic' ),
        ( 986, 78, 'S40' ),
        ( 987, 78, 'V40' ),
        ( 988, 78, 'V50' ),
        ( 989, 78, 'V70 Xc' ),
        ( 990, 78, 'Xc70' ),
        ( 991, 78, 'C70' ),
        ( 992, 78, 'S80' ),
        ( 993, 78, 'S60' ),
        ( 994, 78, 'Xc90' ),
        ( 995, 78, 'C30' ),
        ( 996, 78, '780' ),
        ( 997, 78, '760' ),
        ( 998, 78, '740' ),
        ( 999, 78, '240' )
GO

INSERT  INTO VehModelos
        ( IdModelo, IdMarca, Modelo )
VALUES  ( 1000, 78, '360' ),
        ( 1001, 78, '340' ),
        ( 1002, 78, 'Xc60' ),
        ( 1003, 78, 'V60' ),
        ( 1004, 78, 'V40 Cross Country' ),
        ( 1005, 79, '353' ),
        ( 1006, 53, 'Mini' ),
        ( 1007, 53, 'Countryman' ),
        ( 1008, 53, 'Paceman' )
GO
