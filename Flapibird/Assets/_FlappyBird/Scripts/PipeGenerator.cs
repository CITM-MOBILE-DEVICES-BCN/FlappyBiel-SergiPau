using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public float timeToRepeat = 5;
    public GameObject[] pipePrefab;
    public float speed = 4;
    public DifficultyManager difficultyManager;
    IPipeBuilder pipeBuilder;
    private PipeBuilderDirector pipeBuilderDirector;

    void Start()
    {
        pipeBuilderDirector = new PipeBuilderDirector();

        if (difficultyManager != null)
        {
           difficultyManager.onDifficultyIncrease.AddListener(OnDifficultyIncreased);
        }
        StartCoroutine(CreatePipes());
    }

    void OnDifficultyIncreased()
    {
        speed += 0.5f / 3;
        
        if (timeToRepeat >= 1)
        {
            timeToRepeat -= 0.1f;
        }
    }

    IEnumerator CreatePipes()
    {
        while (true)
        {
            
            GameObject pipe;
            switch (Random.Range(0, 4))
            {
                case 0:
                    pipeBuilder = new NormalPipe(pipePrefab[Random.Range(0, pipePrefab.Length)], transform.position, Quaternion.identity);
                    break;
                case 1:
                    pipeBuilder = new MovingPipe(pipePrefab[Random.Range(0, pipePrefab.Length)], transform.position, Quaternion.identity);
                    break;
                case 2:
                    pipeBuilder = new InvertionPipe(pipePrefab[Random.Range(0, pipePrefab.Length)], transform.position, Quaternion.identity);
                    break;
                case 3:
                    pipeBuilder = new DissapearingPipes(pipePrefab[Random.Range(0, pipePrefab.Length)], transform.position, Quaternion.identity);
                    break;
            }

            pipeBuilderDirector.Construct(pipeBuilder);
            pipe = pipeBuilder.GetPipe();
            pipe.GetComponent<PipeObstacle>().speed = speed;
            pipe.GetComponent<PipeObstacle>().difficultyManager = difficultyManager;


            yield return new WaitForSeconds(timeToRepeat);
        }
        
    }

}
