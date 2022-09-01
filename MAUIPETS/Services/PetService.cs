﻿using System;
using MAUIPETS.Models;

namespace MAUIPETS.Services
{
	public static class PetService
	{
		public static List<Pet> PetsData = new()
		{
			new()
			{
				Name="Stevie Girl",
				Image="https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/47852639/1/?bust=1589792883",
				Breed="Domestic short hair",
				Type="Cat",
				Location="Mission, TX",
				Size="Adult",
				Gender="Female",
				Health="Vaccinations up to date, spayed / neutered, special needs. Blind, but functional.",
				Meet="Stevie Girl is a large dilute tortoiseshell with extremely soft fur, who tips the scales at a substantial 14 pounds. Being blind, her vision impairment isnt readily apparent since she behaves very much like a normal cat when she is in her accustomed surroundings. She likes to play and is able to jump up on furniture and make her way around without bumping into things. She is very sweet, but can be feisty and energetic, as well as loving and full of purrs.",
				Social="Good in home with Other cats. ",
				Url="https://www.petfinder.com/cat/stevie-girl-47852639/tx/mission/cinderella-pet-rescue-inc-tx1280/"
			},
			new()
			{
				Name="Mars",
				Image="https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/41177233/3/?bust=1589792859",
				Breed="Rottweiler & Labrador Retriever Mix",Type="Dog",Location="Mission, TX",
				Size="Adult",Gender="Female",
				Health="Vaccinations up to date, spayed / neutered.",
				Meet="Mars was born in June of 2012 and weighs about 55 pounds. She is a little shy at first but once she warms up she becomes very friendly and affectionate. She likes to play with most dogs and walks well on a leash. She rides politley in the car and is a patient beauty. She will bark to let you know when a stranger shows up. But she is too shy to be aggressive. Mars just wants to be loed and treated kindly. Mars is ready to join her forever home. Give this beauty a chance to be a part of your life.",Social="Good in home with Other dogs. ",
				Url="https://www.petfinder.com/dog/mars-41177233/tx/mission/cinderella-pet-rescue-inc-tx1280/"

			},
			new()
			{
				Name="Lady",
				Image="https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/47636387/1/?bust=1589811913",
				 Breed="German Shepherd Dog",
				 Type="Dog",
				 Location="Corpus Christi, TX",
				 Size="Medium",
				 Gender="Female",
				 Health="Spayed / neutered, special needs.",
				 Meet="Primary Color: Tan Secondary Color: Black Weight: 61lbs Age: 8yrs 2mths 1wks Animal has been Spayed",
				 Social="Good in home with Other dogs.",
				 Url="https://www.petfinder.com/dog/lady-47636387/tx/corpus-christi/gulf-coast-humane-society-tx476/"},
            new()
            {
				Name="Elizapet Taylor",
				 Image="https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/46470703/1/?bust=1589792874",
				 Breed="Husky & Australian Shepherd Mix",
				 Type="Dog",
				 Location="Mission, TX",
				 Size="Medium",
				 Gender="Female",
				 Health="Vaccinations up to date, spayed / neutered.",
				 Meet="Elizapet Taylor (AKA Liz) is a gorgeous lady. She was born in January 2019 and weighs about 50 pounds. With her beautiful blue eyes and fluffy tail she is a real beauty. Liz is playful and gets along well with other dogs. She eagerly joins you for long walks and rides well in the car, happy to acompany you on all your journeys. She loves to be with people and is a happy girl. Liz is a real princess, ready to be a part of your castle!",
				 Social="Good in home with Other dogs, children.",
				 Url="https://www.petfinder.com/dog/elizapet-taylor-46470703/tx/mission/cinderella-pet-rescue-inc-tx1280/"},
            new()
            {
				Name="Elaine",
				 Image="https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/47902423/1/?bust=1588436009",
				 Breed="Domestic Short Hair Mix",
				 Type="Cat",
				 Location="Corpus Christi, TX",
				 Size="Medium",
				 Gender="Female",
				 Health="Spayed / neutered.",
				 Meet="Primary Color: Orange Tabby Weight: 7.4lbs Age: 1yrs 3mths 3wks Animal has been Spayed",
				 Social="Good in home with Other cats.",
				 Url="https://www.petfinder.com/cat/elaine-47902423/tx/corpus-christi/gulf-coast-humane-society-tx476/"},
            new()
            {

				Name = "Lily",
				 Image = "https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/47721715/2/?bust=1589826464",
				 Breed = "Domestic Short Hair",
				 Type = "Cat",
				 Location = "South Padre Island, TX",
				 Size = "Medium",
				 Gender = "Female",
				 Health = "Vaccinations up to date, spayed / neutered.",
				 Meet = "Lily is a cross-eyed, beautiful orange cat. Very playful and loving. She will be one of the first cats to greet you if you come by the kennel that she is in. She gets along with other cats just fine but she does get skittish in new environments. Lily loves to be petted and will purr constantly when given attention. She is such a cuddle bug.",
				 Social = "Good in home with Other cats.",
				 Url = "https://www.petfinder.com/cat/lily-47721715/tx/south-padre-island/friends-of-animal-rescue-tx2248/"},
            new()
            {

				Name = "Onyx",
				 Image = "https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/47041892/2/?bust=1589826603",
				 Breed = "Domestic Short Hair",
				 Type = "Cat",
				 Location = "South Padre Island, TX",
				 Size = "Medium",
				 Gender = "Female",
				 Health = "Vaccinations up to date, spayed / neutered.",
				 Meet = "Onyx is a female cat that is ready for her FUR-ever home. She has been spayed, is up to date on all her vaccinations, tested negative for FIV and Felv, and is micro-chipped. Onyx gets along with other cats, loves humans and is very social. She will make a great companion for any human.",
				 Social = "Good in home with other cats, dogs, children.",
				 Url = "https://www.petfinder.com/cat/onyx-47041892/tx/south-padre-island/friends-of-animal-rescue-tx2248/"},
			new()
			{

				Name = "Blackie",
				 Image = "https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/47809550/1/?bust=1586880668",
				 Breed = "Domestic Short Hair Mix",
				 Type = "Cat",
				 Location = "Corpus Christi, TX",
				 Size = "Medium",
				 Gender = "Female",
				 Health = "Spayed / neutered.",
				 Meet = "Primary Color: Black Weight: 8.6lbs Age: 1yrs 3mths 4wks Animal has been Spayed",
				 Social = "Good in home with Other cats.",
				 Url = "https://www.petfinder.com/cat/blackie-47809550/tx/corpus-christi/gulf-coast-humane-society-tx476/"},
            new()
            {

				Name = "Shayko",
				 Image = "https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/41036181/1/?bust=1519454705",
				 Breed = "Alaskan Malamute Mix",
				 Type = "Dog",
				 Location = "Mcallen, TX",
				 Size = "Large",
				 Gender = "Male",
				 Health = "Vaccinations up to date, spayed / neutered.",
				 Meet = "Malamute/husky mix neutered, microchipped, fully vetted and ready for his forever home. Very obedient, sweet boy!",
				 Social = "Good in home with Other dogs.",
				 Url = "https://www.petfinder.com/dog/shayko-41036181/tx/mcallen/dr-dolittles-rescue-ranch-tx1177"},
            new()
            {

				Name = "Aurora",
				 Image = "https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/43991676/2/?bust=1589216440",
				 Breed = "Pit Bull Terrier",
				 Type = "Dog",
				 Location = "South Padre Island, TX",
				 Size = "Large",
				 Gender = "Female",
				 Health = "Vaccinations up to date, spayed / neutered.",
				 Meet = "Aurora is a beauty! Our staff has done a great job in getting her socialized with volunteers. She loves her walks and keeps her kennel dry. She loves people but isn't fond of other pets or small kids. We are looking for a family for Aurora that will love her as an only child. Aurora is about 2-3 years old. She is spayed, vaccinated, heart worm negative and micro chipped.",
				 Social = "Good in home with Other dogs, cats, childrens.",
				 Url = "https://www.petfinder.com/dog/aurora-43991676/tx/south-padre-island/friends-of-animal-rescue-tx2248/"},
            new()
            {

				Name = "Kalani",
				 Image = "https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/47533384/1/?bust=1583340044&width=720",
				 Breed = "Labrador Retriever Mix",
				 Type = "Dog",
				 Location = "Corpus Christi, TX",
				 Size = "Medium",
				 Gender = "Female",
				 Health = "Spayed / neutered.",
				 Meet = "Primary Color: Brown Secondary Color: White Weight: 70lbs Age: 1yrs 3mths 2wks Animal has been Spayed",
				 Social = "Good in home with Other dogs.",
				 Url = "https://www.petfinder.com/dog/kalani-47533384/tx/corpus-christi/gulf-coast-humane-society-tx476/"},
            new()
            {

				Name = "Plum",
				 Image = "https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/47241499/1/?bust=1580326701",
				 Breed = "German Shepherd Dog & Husky Mix",
				 Type = "Dog",
				 Location = "Mcallen, TX",
				 Size = "Large",
				 Gender = "Male",
				 Health = "Vaccinations up to date, spayed / neutered.",
				 Meet = "Meet Plum, a 6 year old Husky /Shepherd mix that came from a kill shelter in east LA. He is housebroken, dog and people social and a healthy boy This beautiful boy deserves a forever home.",
				 Social = "Good in home with Other dogs.",
				 Url = "https://www.petfinder.com/dog/plum-47241499/tx/mcallen/dr-dolittles-rescue-ranch-tx1177/"},
            new()
            {

				Name = "Bruno",
				 Image = "https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/48001632/1/?bust=1589661622",
				 Breed = "German Shepherd Dog",
				 Type = "Dog",
				 Location = "Corpus Christi, TX",
				 Size = "Large",
				 Gender = "Male",
				 Health = "Spayed / neutered.",
				 Meet = "Primary Color: Black Secondary Color: Cream Weight: 70.4lbs Age: 0yrs 9mths 0wks Animal has been Neutered",
				 Social = "Good in home with Other dogs.",
				 Url = "https://www.petfinder.com/dog/bruno-48001632/tx/corpus-christi/gulf-coast-humane-society-tx476/"},
            new()
            {

				Name = "Chuck",
				 Image = "https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/47839455/5/?bust=1589217877",
				 Breed = "Pit Bull Terrier",
				 Type = "Dog",
				 Location = "South Padre Island, TX",
				 Size = "Medium",
				 Gender = "Male",
				 Health = "Vaccinations up to date, spayed / neutered.",
				 Meet = "Chuck is full of energy. He loves going for walks, loves treats, loves toys, and gives lots of kisses. Chuck will even come up to you for hugs! He is a great pup all around!",
				 Social = "Good in home with Other dogs.",
				 Url = "https://www.petfinder.com/dog/chuck-47839455/tx/south-padre-island/friends-of-animal-rescue-tx2248/"},
			new()
			{

				Name = "Buddy",
				 Image = "https://dl5zpyw5k3jeb.cloudfront.net/photos/pets/38821061/1/?bust=1500564464",
				 Breed = "Airedale Terrier & Poodle Mix",
				 Type = "Dog",
				 Location = "San Miguel De Allende, GUA",
				 Size = "Large",
				 Gender = "Male",
				 Health = "Spayed / neutered, special needs.",
				 Meet = "Buddy is an Airedoodle! He has the characteristics of both breeds (Airedale and Poodle) – intelligent, loyal, curious, energetic, playful, and people-loving! He came to the S.P.A. on December 4, 2014 when he was about 6 years old. He had been part of a family his whole life and then the owner moved to an apartment – too small for Buddy! He is an ideal family pet, but we’ve now learned that he would do best as the only dog in the family and he needs ready access to the outside. Also, no cats for sure. His favorite toy is a deflated soccer ball!",
				 Social = "Good in home with Other dogs.",
				 Url = "https://www.petfinder.com/dog/buddy-38821061/gua/san-miguel-de-allende/sociedad-protectora-de-animales-mxgua01/" }

        };
	}
}