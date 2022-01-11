/* Lance Rogan
 * 
 * This is a very simple program that creates a randomly generated password for a user to use
 * for their login or newly created account
 * 
 */

import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;
import java.util.Scanner;

public class generator {

	public static void main(String[] args) {

		// creating a scanner object to take input from user keyboard
		Scanner input = new Scanner(System.in);

		// print statements to gather user data and preferences for their password
		System.out.print("How many characters would you like in your password? ");
		int characters = input.nextInt();

		System.out.print("How many special characters would you like in your password? ");
		int specialCharacters = input.nextInt();

		System.out.print("How many numbers would you like in your password? ");
		int numbers = input.nextInt();

		System.out.print("Great! Here is your password: ");

		// initializing arraylist of characters, char c and random object
		ArrayList<Character> passwordShuffle = new ArrayList<Character>();
		char c;
		Random random = new Random();

		// for each character required do the following
		for (int i = 0; i < characters; i++) {
			// generate a random character a-z (lowercase)
			c = (char) (random.nextInt(26) + 97);

			// if a random number is even AKA divisible by 2, convert character to uppercase
			if (random.nextInt(100) % 2 == 0) {
				passwordShuffle.add(Character.toUpperCase(c));
			} else {
				// otherwise leave it as lowercase
				passwordShuffle.add(c);
			}

		}

		// for each special character required do the following
		for (int i = 0; i < specialCharacters; i++) {
			// generate a random special character
			c = (char) (random.nextInt(6) + 33);
			// add to password
			passwordShuffle.add(c);

		}
		// for each number required do the following
		for (int i = 0; i < numbers; i++) {
			// generate a random number from 0-9
			c = (char) (random.nextInt(10) + 48);
			// add to password
			passwordShuffle.add(c);

		}

		// shuffle the password
		Collections.shuffle(passwordShuffle);

		// print out the password to the user
		for (int i = 0; i < passwordShuffle.size(); i++) {
			System.out.print(passwordShuffle.get(i));
		}

	}

}
