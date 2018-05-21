node {
   stage('Starting the pipeline'){
       echo "Just the first stage"
   }
   
   stage('Cloning the repo') {
       echo "Downloading original source"
       deleteDir()
       sh 'git clone -c http.sslverify=false https://github.com/sujeet-kr/dotnet-core-auto-framework.git ${WORKSPACE}/original/'
    //   sh 'git clone https://${GITLAB_ACCESS_TOKEN}:x-oauth-basic@gitlab.fleetcomplete.com/QA-Automation/FC-Automation-POC.git ${WORKSPACE}/original/'
      sh 'cd ${WORKSPACE}/original'
   }
   
   stage('Stage after cloning'){
       echo "This is not required for testing"
   } 

   stage('Running tests') {
       echo "Running the tests"
       sh 'cd ./original/tests'
       sh 'dotnet test ./original/tests/fc.test.project.csproj'
   }
}