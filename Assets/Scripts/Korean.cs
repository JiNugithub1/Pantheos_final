using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Korean : MonoBehaviour
{
    bool isMoving = false; // ������Ʈ�� �����̰� �ִ��� ���θ� ��Ÿ���� ����
    int left = 0;
    int right = 0;
    int up = 0;
    int down = 0;
    int leftup = 0;
    int rightup = 0;
    int leftdown = 0;
    int rightdown = 0;

    public GameObject GreeceThrowBtn;
    public GameObject KoreanThrowBtn;
    public Animator yutAnimator; // 윷 애니메이터
    public GameObject leftupBtn;
    public GameObject rightupBtn;
    public GameObject leftdownBtn;
    public GameObject rightdownBtn;
    public GameObject leftBtn;
    public GameObject rightBtn;

    void Update()
    {

    }

    public void ThrowBtnOnClick()
    {
        int count = 0;
        int more = 1;
        // 도, 개, 걸, 윷, 모의 확률을 결정하기 위한 랜덤 숫자 생성 (1부터 16까지)
        int num = Random.Range(1, 17);

        if (!isMoving)
        {
            // 도, 개, 걸, 윷, 모 확률 계산
            if (num < 5)
            {
                count = 1;  // 도
                Debug.Log("도입니다, 현재 값 : " + count);
            }
            else if (num >= 5 && num < 11)
            {
                count = 2;  // 개
                Debug.Log("개입니다, 현재 값 : " + count);
            }
            else if (num >= 11 && num < 15)
            {
                count = 3;  // 걸
                Debug.Log("걸입니다, 현재 값 : " + count);
            }
            else if (num == 15)
            {
                count = 4;  // 윷
                Debug.Log("윷입니다, 현재 값 : " + count);
            }
            else if (num == 16)
            {
                count = 5;  // 모
                Debug.Log("모입니다, 현재 값 : " + count);
            }

            // 애니메이터에 도, 개, 걸, 윷, 모에 해당하는 랜덤 숫자 설정
            yutAnimator.SetInteger("RandomNumber", count);

            // 윷 굴리기 애니메이션 재생
            yutAnimator.SetTrigger("Roll");
            StartCoroutine(MoveKorean(count)); // 캐릭터 이동 코루틴 실행
        }
    }


    IEnumerator MoveKorean(int yutResult)
    {
        isMoving = true; // ������ ����
        KoreanThrowBtn.SetActive(false);

        // �� ����� ���� �̵�
        for (int i = 0; i < yutResult; i++)
        {
            // ��� ������
            if (transform.position == new Vector3(0, 6, transform.position.z))
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }
            // ���� �� ������
            else if (transform.position == new Vector3(-24, 30, transform.position.z))
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }
            // ������ �� ������
            else if (transform.position == new Vector3(24, 30, transform.position.z))
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }
            // ���� �Ʒ� ������
            else if (transform.position == new Vector3(-24, -18, transform.position.z))
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }
            // ������ �Ʒ� ������
            else if (transform.position == new Vector3(24, -18, transform.position.z))
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }

            // ������ 12�ÿ��� ����
            else if (transform.position == new Vector3(0, 54, transform.position.z) && i == 0)
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }
            // ������ 3�ÿ��� ����
            else if (transform.position == new Vector3(48, 6, transform.position.z) && i == 0)
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }
            // ������ 6�ÿ��� ����
            else if (transform.position == new Vector3(0, -42, transform.position.z) && i == 0)
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }
            // ������ 9�ÿ��� ����
            else if (transform.position == new Vector3(-48, 6, transform.position.z) && i == 0)
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }

            // ������ 12�� ������
            else if (transform.position == new Vector3(0, 54, transform.position.z) && i != 0)
            {
                if (leftup == 1)
                {
                    leftup = 0;
                    leftdown = 1;
                    transform.Translate(new Vector2(-4f, -4f));
                }
                if (rightup == 1)
                {
                    rightup = 0;
                    rightdown = 1;
                    transform.Translate(new Vector2(4f, -4f));
                }
                yield return null; // ���� �����ӱ��� ���
            }
            // ������ 3�� ������
            else if (transform.position == new Vector3(48, 6, transform.position.z) && i != 0)
            {
                if (rightdown == 1)
                {
                    rightdown = 0;
                    leftdown = 1;
                    transform.Translate(new Vector2(-4f, -4f));
                }
                if (rightup == 1)
                {
                    rightup = 0;
                    leftup = 1;
                    transform.Translate(new Vector2(-4f, 4f));
                }
                yield return null; // ���� �����ӱ��� ���
            }
            // ������ 6�� ������
            else if (transform.position == new Vector3(0, -42, transform.position.z) && i != 0)
            {
                if (leftdown == 1)
                {
                    leftdown = 0;
                    leftup = 1;
                    transform.Translate(new Vector2(-4f, 4f));
                }
                if (rightdown == 1)
                {
                    rightdown = 0;
                    rightup = 1;
                    transform.Translate(new Vector2(4f, 4f));
                }
                yield return null; // ���� �����ӱ��� ���
            }
            // ������ 9�� ������
            else if (transform.position == new Vector3(-48, 6, transform.position.z) && i != 0)
            {
                if (leftup == 1)
                {
                    leftup = 0;
                    rightup = 1;
                    transform.Translate(new Vector2(4f, 4f));
                }
                if (leftdown == 1)
                {
                    leftdown = 0;
                    rightdown = 1;
                    transform.Translate(new Vector2(4f, -4f));
                }
                yield return null; // ���� �����ӱ��� ���
            }

            // ���� �Ա�
            else if (transform.position == new Vector3(-28, 34, transform.position.z))
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad4))
                {
                    transform.Translate(new Vector2(-8f, 0f));
                    left = 1;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }
            // ��� �Ա�
            else if (transform.position == new Vector3(28, 34, transform.position.z))
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad6))
                {
                    transform.Translate(new Vector2(8f, 0f));
                    left = 0;
                    right = 1;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }
            // �縷 �Ա�
            else if (transform.position == new Vector3(28, -22, transform.position.z))
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad6))
                {
                    transform.Translate(new Vector2(8f, 0f));
                    left = 0;
                    right = 1;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }
            // ���� �Ա�
            else if (transform.position == new Vector3(-28, -22, transform.position.z))
            {
                // ������ ���� Ű �Է¿� ���� �̵�
                if (Input.GetKeyDown(KeyCode.Keypad4))
                {
                    transform.Translate(new Vector2(-8f, 0f));
                    left = 1;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else // �Է��� ������ �̵����� ����
                    i--; // �ֻ��� ����� �ϳ� ���ҽ��Ѽ� �ٽ� �̵��� �� �ֵ��� ��

                yield return null; // ���� �����ӱ��� ���
            }

            // ���簢�� ���� �̵�
            else if (transform.position == new Vector3(-60, 34, transform.position.z) || transform.position == new Vector3(60, 34, transform.position.z) || transform.position == new Vector3(28, -46, transform.position.z) || transform.position == new Vector3(-28, -46, transform.position.z))
            {
                transform.Translate(new Vector2(0f, 8f));
                left = 0;
                right = 0;
                up = 1;
                down = 0;
                leftup = 0;
                rightup = 0;
                leftdown = 0;
                rightdown = 0;

                yield return null; // ���� �����ӱ��� ���
            }
            // ���簢�� ���������� �̵�
            else if (transform.position == new Vector3(-60, 58, transform.position.z) || transform.position == new Vector3(-60, -46, transform.position.z))
            {
                transform.Translate(new Vector2(8f, 0f));
                left = 0;
                right = 1;
                up = 0;
                down = 0;
                leftup = 0;
                rightup = 0;
                leftdown = 0;
                rightdown = 0;

                yield return null; // ���� �����ӱ��� ���
            }
            // ���簢�� �������� �̵�
            else if (transform.position == new Vector3(60, 58, transform.position.z) || transform.position == new Vector3(60, -46, transform.position.z))
            {
                transform.Translate(new Vector2(-8f, 0f));
                left = 1;
                right = 0;
                up = 0;
                down = 0;
                leftup = 0;
                rightup = 0;
                leftdown = 0;
                rightdown = 0;

                yield return null; // ���� �����ӱ��� ���
            }
            // ���簢�� �Ʒ��� �̵�
            else if (transform.position == new Vector3(-28, 58, transform.position.z) || transform.position == new Vector3(28, 58, transform.position.z) || transform.position == new Vector3(60, -22, transform.position.z) || transform.position == new Vector3(-60, -22, transform.position.z))
            {
                transform.Translate(new Vector2(0f, -8f));
                left = 0;
                right = 0;
                up = 0;
                down = 1;
                leftup = 0;
                rightup = 0;
                leftdown = 0;
                rightdown = 0;

                yield return null; // ���� �����ӱ��� ���
            }

            // ���� �� �̵�
            else if (leftup == 1)
            {
                transform.Translate(new Vector2(-4f, 4f));
                yield return null; // ���� �����ӱ��� ���
            }
            // ������ �� �̵�
            else if (rightup == 1)
            {
                transform.Translate(new Vector2(4f, 4f));
                yield return null; // ���� �����ӱ��� ���
            }
            // ���� �Ʒ� �̵�
            else if (leftdown == 1)
            {
                transform.Translate(new Vector2(-4f, -4f));
                yield return null; // ���� �����ӱ��� ���
            }
            // ������ �Ʒ� �̵�
            else if (rightdown == 1)
            {
                transform.Translate(new Vector2(4f, -4f));
                yield return null; // ���� �����ӱ��� ���
            }
            // ���� �̵�
            else if (left == 1)
            {
                transform.Translate(new Vector2(-8f, 0f));
                yield return null; // ���� �����ӱ��� ���
            }
            // ������ �̵�
            else if (right == 1)
            {
                transform.Translate(new Vector2(8f, 0f));
                yield return null; // ���� �����ӱ��� ���
            }
            // ���� �̵�
            else if (up == 1)
            {
                transform.Translate(new Vector2(0f, 8f));
                yield return null; // ���� �����ӱ��� ���
            }
            // �Ʒ��� �̵�
            else if (down == 1)
            {
                transform.Translate(new Vector2(0f, -8f));
                yield return null; // ���� �����ӱ��� ���
            }
        }

        isMoving = false; // ������ ����
        GreeceThrowBtn.SetActive(true);
    }
}