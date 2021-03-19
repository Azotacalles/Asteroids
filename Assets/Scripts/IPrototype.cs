namespace Asteroids
{
    interface IPrototype
    {
        IPrototype Clone(IEnemyFactory enemyFactory);
    }
}
