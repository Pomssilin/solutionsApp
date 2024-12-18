pipeline {
    agent any

    stages {
        stage('Checkout Code') {
            steps {
                // Récupérer le code depuis GitHub
                git 'https://github.com/Pomssilin/solutionsApp.git'
            }
        }

        stage('Build Project1') {
            steps {
                // Compiler Project1
                echo "Building Project1..."
                dir('TestProject1') { // Changer de répertoire pour Project1
                    sh 'dotnet build --configuration Release'
                }
            }
        }
        stage('Test') {
            steps {
                echo 'Testing...'
                // Commande pour exécuter les tests (exemple : mvn test ou npm test)
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying...'
                // Commande pour déployer le projet (exemple : copie des fichiers ou appel API)
            }
        }
    }
}