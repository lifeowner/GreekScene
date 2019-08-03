# GreekScene
Είναι ένα API το οποίο μπορείτε να βάλετε στο "Project" σας στο Visual Studio με τον σκοπό υποχρεωτικής εισόδου με το όνομα χρήστη και κωδικό του υπάρχων φόρουμ.

Ωστόσο όμως θα πρέπει να προσέξετε κάποια πράγματα πρην την εγκατάσταση όπως:

Θα πρέπει εαν μιλάμε για μια γλώσσα μετάφρασης του προγράμματος που παρέχει μη λατινικούς χαρακτίρες το αρχείο να είναι Unicode, εαν δεν ξέρετε πως γίνετε αυτό και για ποιό λόγο, μπορείτε απλά να κάνετε αντιγραφή το αρχείο στον φάκελο languages el_GR.ini το οποίο είναι ίδη Unicode. Στην συνέχεια μπορείτε να το ονομάσετε όπως θέλετε και να μεταφράσετε κανονικά σε μια καινούρεια γλώσσα την φόρμα εισόδου.

Επήσεις μην ξεχάσετε ότι είναι συμαντικό στην αρχή του αρχείου να υπάρχη ακριβώς έτσι γραμμένο η ετικέτα του .ini, θεωρίτε κατιγορία και είναι ο τρόπος που διαβάζει το αρχείο αυτό το API μας.
[GreekScene.eu]

Ένα παράδιγμα μετάφρασης είναι:

[GreekScene.eu]
copyright=Πνευματική ιδιοκτησία (c) 
register=Κανω ΕΓΓΡΑΦΗ
signin=Συνδεθείτε
passwordforgot=Ξεχάσατε τον κωδικό σας;
auth_failed=Δεν ήταν δυνατή η σύνδεσή σας, πληκτρολογείτε λάθος κωδικό πρόσβασης ή δεν έχετε ακόμα εγγραφεί.


Ωστόσο όμως για να λειτουργίσει στο πρόγραμμα σας σωστά το API θα πρέπει να βάλετε τον παρακάτω κώδικα στην φώρτοση της φόρμας σας.


        private void Form1_Load(object sender, EventArgs e)
        {
            GreekScene_API_V2.sign_in_form RequiredSignIn = new GreekScene_API_V2.sign_in_form();
            RequiredSignIn.ShowDialog();
        }
	
Όμως εαν δεν γνωρίζετε πως να τα κάνετε όλα αυτά σας παρέχουμε ενα "Example" Project σε C# το οποίο μπορείτε να κατεβάσετε και να χρησημοποιήσετε.
Είναι πολύ απλό, εύκολο και χρήσημο! Ελποίζω να το χαρίτε!

Όσοι δεν γνωρίζετε για την ιστοσελίδα μας, μπείτε!

https://greekscene.eu
