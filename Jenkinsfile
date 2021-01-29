properties([
  parameters([
     choice(name: 'DevComputer', description: 'Dev Machine', choices: ['<REPLACE WITH YOUR DEV BOX>']),
     string(name: 'QAEnv', defaultValue: 'QAENV08', description: 'The name of the QA Env.'),
     booleanParam(name: 'deploytodev', defaultValue: false, description: 'Deploy to dev'),
     booleanParam(name: 'deploytodemo', defaultValue: false, description: 'Deploy to demo'),
     booleanParam(name: 'DeployToDevK8s', defaultValue: false, description: 'Deploy to dev (feature branch) namespace on Kubernetes'),
     string(name: 'SlackChannel', defaultValue: '#<YOUR CHANNEL NAME HERE>', description: 'The name of the slack channel that you want build notifications published to.'),
     booleanParam(name: 'SendSlackNotifications', defaultValue: true, description: 'enable/disable slack notifications'),
     string(name: 'MasterBranchName', defaultValue: 'master', description: 'The name of the branch to consider "master"')
  ])
])
NetCorePipeline()