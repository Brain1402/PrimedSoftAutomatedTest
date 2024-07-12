pipeline {
    agent any

    environment {
        // Define your environment variables if needed
        // e.g. PATH = "${env.PATH}:C:\\path\\to\\mstest"
    }

    stages {
        stage('Checkout') {
            steps {
                // Clone the repository
                git 'https://github.com/Brain1402/PrimedSoftAutomatedTest.git'
            }
        }

        stage('Restore NuGet Packages') {
            steps {
                // Restore NuGet packages
                bat 'nuget restore'
            }
        }

        stage('Build') {
            steps {
                // Build the solution
                bat 'msbuild /p:Configuration=Release'
            }
        }

        stage('Run Tests') {
            steps {
                // Run MSTest
                bat 'vstest.console.exe /logger:trx /ResultsDirectory:"%cd%\\TestResults" path\\to\\your\\test\\project.dll'
            }
        }

        stage('Publish Test Results') {
            steps {
                // Publish the test results
                junit 'TestResults/*.trx'
            }
        }
    }

    post {
        always {
            // Clean up workspace
            cleanWs()
        }
        success {
            // Notify success (e.g., via email, Slack, etc.)
            echo 'Build and tests succeeded!'
        }
        failure {
            // Notify failure (e.g., via email, Slack, etc.)
            echo 'Build or tests failed.'
        }
    }
}
