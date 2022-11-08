using TowerDefense_TheRPG.code;

namespace TDRPGCode {
    public class Wave {
        public bool isGameActive = true;
        public bool isWaveActive = false;

        private int currentEnemies = 0;
        private int maxEnemies;
        public int waveNumber = 0;
        public int maxWaveNumber;
        private int enemyMultipler = 3;
        private float spawnRate = 0.0f;
        private Random rand = new Random();
        public List<Enemy> enemies;
        
        // ctor
        public Wave(int maxWaveNumber, int maxEnemies, float spawnRate) {
            enemies = new List<Enemy>();
            this.maxWaveNumber = maxWaveNumber;
            this.maxEnemies = maxEnemies;
            this.spawnRate = spawnRate;
        }
        
        // spawns a new wave of enemies
        public void SpawnNewWave(int height, int width) {
            while(isGameActive && isWaveActive && waveNumber < maxWaveNumber) {
                // Generate a position, determine what enemy to spawn, and increment the enemy counter
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
                    currentEnemies++;

                    // If the player is dead, stop spawning enemies.
                    if(!isGameActive) {
                        break;
                    }
                }

                // Set up for the next wave.
                maxEnemies += enemyMultipler;
                isWaveActive = false;
            }
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

        
    }
}
