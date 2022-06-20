"# Coding Challenge" 


"# System design" 

**1. Tiny URL (Asked Three times)**

**2. Multi-Region Cloud Deployment System:** 
Design a deployment platform to be able to deploy the subscribed services to configured region. Build is out of scope only deployer. Service should be able to,
      1. Handle multi build deployments (multiple builds triggered by merges)
      2. Handle concurrent deployments for a service
      3. Keep track of all historical deployment logs
      4. Deployer has no knowledge of the actual deployment process in other words all the deployment automation is provided by the owning team. Job is only to execute the deployer provided by the onboarded team. 
      5. Service need to propogate the success/failure back to the CI/CD platform
      6. Provided configurable retry mechanism
      7. to onboard-offboard as they need, region configurability, deployer ne
