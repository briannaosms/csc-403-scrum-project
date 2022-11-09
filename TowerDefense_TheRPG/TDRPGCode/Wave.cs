using System.Diagnostics;
using TowerDefense_TheRPG.code;

namespace TDRPGCode {
    public class Wave {
        private bool isGameActive = true;
        private bool isWaveActive = false;

        private int maxEnemies;
        private int waveNumber;
        public int maxWaveNumber;

        public List<Enemy> enemies;
        private Random rand; 
        
        // ctor
        public Wave(int maxWaveNumber, int maxEnemies) {
            enemies = new List<Enemy>();
            this.rand = new Random();
            this.waveNumber = 0;

            this.maxWaveNumber = maxWaveNumber;
            this.maxEnemies = maxEnemies;
        }
        
        // pawns a new wave of enemies
        public void SpawnNewWave(int height, int width) {
            while(IsSpawnConditionMet()) {
                // Generate a position, determine what enemy to spawn, and increment the enemy counter
                Debug.WriteLine(maxEnemies);
                for(int i = 0; i < maxEnemies; i++) {
                    int enemyType = rand.Next(4);
                    Enemy e;

                    GenerateEnemyPosition(height, width, out int x, out int y);

                    switch (enemyType) {
                        case 0:
                            e = Enemy.MakeRedBalloon(x, y);
                            break;
                        case 1:
                            e = Enemy.MakePurpleBalloon(x, y);
                            break;
                        case 2:
                            e = Enemy.MakeGrayBalloon(x, y);
                            break;
                        default:
                            e = Enemy.MakeOrangeBalloon(x, y);
                            break;

                    }
                    enemies.Add(e);

                    // If the player is dead, stop spawning enemies.
                    if(!isGameActive) {
                        break;
                    }
                }

                // Set up for the next wave.
                waveNumber++;
                WaveDifficulty();
                isWaveActive = false;
            }
        }

        public bool IsSpawnConditionMet() {
            return isGameActive && isWaveActive && enemies.Count == 0 && waveNumber < maxWaveNumber;
        }

        // might have to be modified later for random village spawning
        private void GenerateEnemyPosition(int height, int width, out int x, out int y) {
            //Random rand = new Random();
            int enterDir = rand.Next(4);
            const int offscreen = 50;
            switch (enterDir) {
                case 0: // left
                    y = rand.Next(0, height);
                    x = -offscreen;
                    break;
                case 1: // bottom
                    x = rand.Next(0, width);
                    y = height + offscreen;
                    break;
                case 2: // right
                    y = rand.Next(0, height);
                    x = width + offscreen;
                    break;
                default: // top
                    x = rand.Next(0, width);
                    y = -offscreen;
                    break;
            }
        }

        // increases the difficulty for every 3 waves, otherwise just adds an enemy each wave
        private void WaveDifficulty() {
            Debug.WriteLine(waveNumber % 3 == 0);
            if((waveNumber + 1) % 3 == 0) {
                maxEnemies += 5;
            }
            else {
                maxEnemies += 1;
            }
        }


        public void EnableNextWaveSpawning() {
            isWaveActive = true;
        }

        public bool IsGameActive() {
            return isGameActive;
        }

        public void SetGameActive(bool value) {
            isGameActive = value;
        }

        public int GetWaveNumber() {
            return waveNumber;
        }

        public void IncrementWaveNumber() {
            waveNumber++;
        }

    }
}
