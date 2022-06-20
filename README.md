"# Coding Challenge" 

1. WebCrawler.txt --> Search for pre-defined strings, sort and order by the top 'N' finds.

2. InMemoryKeyValueStore.txt --> Implement an in-memory key-value store, for storing a value in a specific path.

3. StreamingData.txt --> Process stream of integers, store and preiodically look up the rank of a given number.

4. ReadactFiles.txt --> Process large amount of text files for restricetd words.

"# System design" 

**1. Tiny URL (Asked Three times)**

**2. Multi-Region Cloud Deployment System:** 

Design a deployment platform to be able to deploy the subscribed services to configured region. Build is out of scope only deployer. Service should be able to,

      1. Handle multi build deployments (multiple builds triggered by merges)
      
      2. Handle concurrent deployments for a service
      
      3. Keep track of all historical deployment logs
      
      4. Deployer has no knowledge of the actual deployment process in other words all the deployment automation is provided by the owning team. 
         Job is only to execute the deployer provided by the onboarded team. 
      
      5. Service need to propogate the success/failure back to the CI/CD platform
      
      6. Provided configurable retry mechanism
      
      7. Systems to be able to onboard-offboard as they need.
