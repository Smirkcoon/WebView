using Firebase.Analytics;
using UnityEngine;

namespace Firebase
{
    public static class FirebaseManager
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        public static void Setup()
        {
            FirebaseApp.Create();
            ConfirmGooglePlayServices();
        }

        private static void ConfirmGooglePlayServices()
        {
            FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
            {
                var dependencyStatus = task.Result;
                if (dependencyStatus != DependencyStatus.Available)
                    Debug.LogError($"Could not resolve all Firebase dependencies: {dependencyStatus}");
            });
        }
    }
}

