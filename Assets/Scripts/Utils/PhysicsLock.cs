using System;
using UnityEngine;

namespace Utils {
    public class PhysicsLock : IDisposable {
        private Action unlockPhysics;
        private Action lockPhysics;
        public PhysicsLock(Action lockPhysics, Action unlockPhysics) {
            this.unlockPhysics = unlockPhysics;
            this.lockPhysics = lockPhysics;
            this.lockPhysics();
        }
        public void Dispose() {
            unlockPhysics();
        }
    }
}
