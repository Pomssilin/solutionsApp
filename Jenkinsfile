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
                    bat 'dotnet build --configuration Release'
                }
            }
        }
        stage('Test') {
            steps {
                echo 'Testing...'
                dir('TestProject1') { // Changer de répertoire pour Project1
                    bat 'dotnet test --configuration Release'
                }
            }
        }
        stage('Dockerize') {
            steps {
                script {
                    // Construire l'image Docker
                    bat '''
                    docker build -t solutionsapp:latest .
                    docker run -p 8080:8080 solutionsapp
                    '''
                }
            }
        }
    }
}
